using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Key_systemAlpha.Properties;
using ZXing;
using Microsoft.Data.Sqlite;
using System.IO;

namespace Key_systemAlpha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form form = new InitForm();
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
        //вспомогательные переменные (костыли)
        int status_time = 5;
        bool camera = true;
        bool I_have_Key_id = false;
        bool I_have_employee_id = false;
        int Key_id = 0, Emp_id = 0;
        int[] Emp_Search_res;
        DBImage DBImage = new DBImage(-1, "", "", null);

        // Запусти приложение, найди свою комеру в комбобоксе
        // поставь сюда индекс своей камеры
        int CameraIndex = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            Cleaner_btn.BackColor = Color.Green;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            HandyAddyGroupBox.Size = new Size(856, 373);
            photoBox.SizeMode = PictureBoxSizeMode.Zoom;

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (filterInfoCollection.Count == 0)
                label1.Text = "no cameras";
            else
            {
                foreach (FilterInfo filterInfo in filterInfoCollection)
                {
                    cboDevice.Items.Add(filterInfo.Name);
                }
                captureDevice = new VideoCaptureDevice(filterInfoCollection[CameraIndex].MonikerString);
                captureDevice.NewFrame += CaptureDevice_NewFrame;
                captureDevice.Start();
                timer.Start();
                cboDevice.SelectedIndex = CameraIndex;

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
            {
                captureDevice.Stop();
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
            this.Dispose();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            cameraBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void cboDevice_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (captureDevice.IsRunning) captureDevice.Stop();
            timer.Stop();
            captureDevice = new VideoCaptureDevice(filterInfoCollection[CameraIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            timer.Start();
            captureDevice.Start();
            CameraIndex = cboDevice.SelectedIndex;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (cameraBox.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)cameraBox.Image);
                if (result != null)
                {
                    string code_id = result.ToString().Split(' ')[0];

                    if (Int32.TryParse(code_id, out int id))//Если в qr зашиты чиселки
                    {
                        if (code_id.Length == 3 && Key_in_base(Convert.ToInt32(code_id)))//Если код ключа и есть в базе
                        {
                            try
                            {
                                KeySkanLabel.Text = "Просканирован ключ " + code_id;
                                if (!Key_is_taken(Convert.ToInt32(code_id)))
                                {
                                    I_have_Key_id = true;
                                    Key_id = Convert.ToInt32(code_id);
                                }
                                else //ветка, если ключ нужно вернуть в базу (т.е. если значение taken=1)
                                {
                                    Return_key(Convert.ToInt32(code_id));
                                    Status_label.Text = "Ключ " + code_id + " возвращен";
                                    Status_label.ForeColor = Color.Green;
                                    Status_timer.Enabled=true;
                                }
                            }
                            catch (Exception)
                            {
                                Status_label.Text = "Код ключа не найден в базе.\n";
                            }
                        }
                        else if (code_id.Length == 5 && Emp_in_base(Convert.ToInt32(code_id)))//Если код сотрудника и есть в базе
                        {
                            try
                            {
                                photoBox.Image = Image.FromFile("..\\..\\Resources\\" + code_id + ".jpg");
                                //Вместе со сканом переключаться на отображение инфы о сотруднике справа-сверху и выводить его данные + фотку
                                Status_label.Text = "Просканирован сотрудник " + code_id;
                                I_have_employee_id = true;
                                Emp_id = Convert.ToInt32(code_id);
                            }
                            catch (FileNotFoundException)
                            {
                                photoBox.Image = Image.FromFile("..\\..\\Resources\\no_photo.jpg");
                                Status_label.Text = "Просканирован сотрудник " + code_id;
                                I_have_employee_id = true;
                                Emp_id = Convert.ToInt32(code_id);
                            }
                            // Здесь нужно обработать SQL экзепшн, если айди не найден
                            catch (Exception)
                            {
                                photoBox.Image = Image.FromFile(
                                      Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Resources\\error.jpg");
                                Status_label.Text = "Код сотрудника не найден в базе.\n";
                            }
                        }
                        else
                        {
                            Status_label.Text = "Неверный формат кода";
                            Status_label.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        Status_label.Text = "Неверный формат кода";
                        Status_label.ForeColor = Color.Red;
                    }
                }
            }

            //а после всех считываний
            if (I_have_employee_id && I_have_Key_id)
            {
                //проверяем сам доступ
                //добавляем в историю (локальную),  если доступ есть
                //шлём инъекцию начальнику,         если доступ есть
                //отображаем статус доступа (разрешен\запрещен)
                //запускаем таймер на отображение статуса
                //по окончании таймера статус меняется на нейтральный "Статус доступа"
                //делаем ложными I_have_employee_id и I_have_Key_id
                //да-да придется снова пробивать и ключ, и сотрудника =)
                //обнуляем Key_id и Emp_id
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (camera) //если отображаем камеру → переключаемся на инфу о сотруднике
            {
                CamEmpGroup.Text = "Информация по сотруднику";
                cameraBox.Visible = false;
                camera = false;

                photoBox.Visible = true;
                Flabel.Visible = true;
                Ilabel.Visible = true;
                Olabel.Visible = true;
                Plabel.Visible = true;

                CamEmpSwitch.Text = "Камера";
            }
            else //если отображаем инфу о сотруднике → переключаемся на камеру
            {
                CamEmpGroup.Text = "Камера";
                cameraBox.Visible = true;
                camera = true;

                photoBox.Visible = false;
                Flabel.Visible = false;
                Ilabel.Visible = false;
                Olabel.Visible = false;
                Plabel.Visible = false;
                
                CamEmpSwitch.Text = "Информация по сотруднику";
            }
        }//переключатель камеры/сотрудника

        //тестова фигня - Выпилить
        private void acces_label_Click(object sender, EventArgs e)
        {
            if (Status_label.Text == "Статус доступа")
            {
                Status_label.ForeColor = Color.Green;
                Status_label.Text = "Разрешен";
            }
            else if(Status_label.Text == "Разрешен")
            {
                Status_label.ForeColor = Color.Red;
                Status_label.Text = "Запрещён";
            }
            else if (Status_label.Text == "Запрещён")
            {
                Status_label.ForeColor = Color.Black;
                Status_label.Text = "Статус доступа";
            }
        }

        private bool Access_confirmed(int pid, int kid)
        {
            int SqlRowCount = 0;
            using (var connection = new SqliteConnection("Data Source=KeysHolder.db"))
            {
                string sql = "SELECT COUNT(*) FROM KEYS_TO_PERSONS WHERE ID_PERSON = " + pid.ToString() + " AND ID_KEY = " + kid.ToString();

                connection.Open();
                SqliteCommand command = new SqliteCommand(sql, connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())   // построчно считываем данные
                        {
                            SqlRowCount = reader.GetInt32(0);
                        }
                    }
                }
            }
            if (SqlRowCount > 0) return true;
            else return false;
        }
        private bool Key_is_taken(int kid)
        {
            int taken = -1;
            using (var connection = new SqliteConnection("Data Source=KeysHolder.db"))
            {
                string sql = "SELECT Taken FROM Keys WHERE ID_KEY = " + kid.ToString();

                connection.Open();
                SqliteCommand command = new SqliteCommand(sql, connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())   // построчно считываем данные
                        {
                            taken = reader.GetInt32(0);
                        }
                    }
                }
            }
            if (taken == 1) return true;
            else return false;
        }
        private bool Key_in_base(int kid)
        {
            int here = -1;
            using (var connection = new SqliteConnection("Data Source=KeysHolder.db"))
            {
                string sql = "SELECT COUNT(*) FROM Keys WHERE ID_KEY = \"" + kid.ToString() + "\"";

                connection.Open();
                SqliteCommand command = new SqliteCommand(sql, connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())   // построчно считываем данные
                        {
                            here = reader.GetInt32(0);
                        }
                    }
                }
            }
            if (here == 1) return true;
            else return false;
        }
        private bool Emp_in_base(int pid)
        {
            int here = -1;
            using (var connection = new SqliteConnection("Data Source=KeysHolder.db"))
            {
                string sql = "SELECT COUNT(*) FROM PERSONS WHERE ID_PERSON = \"" + pid.ToString() + "\"";

                connection.Open();
                SqliteCommand command = new SqliteCommand(sql, connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())   // построчно считываем данные
                        {
                            here = reader.GetInt32(0);
                        }
                    }
                }
            }
            if (here == 1) return true;
            else return false;
        }
        private void Return_key(int kid)
        {
            using (var connection = new SqliteConnection("Data Source=KeysHolder.db"))
            {
                connection.Open();

                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                command.CommandText = @"UPDATE KEYS SET Taken=0 WHERE ID_KEY=@id";
                command.Parameters.Add(new SqliteParameter("@id", kid));
                command.ExecuteNonQuery();
            }
        }

        private bool IdSearch(string str)
        {
            try
            {
                int a = Convert.ToInt32(str);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if(DBImage.Id==-1 || c1TextBox1.Text!= DBImage.Id.ToString() && c1TextBox1.Text != DBImage.Title.Remove(DBImage.Title.IndexOf(" ")))
            {
                listBox1.Items.Clear();
                int SqlRowCount = 0;

                using (var connection = new SqliteConnection("Data Source=KeysHolder.db"))
                {
                    string sql = "";
                    if (IdSearch(c1TextBox1.Text))  //если ищем по айди
                        sql = $"SELECT COUNT(*) FROM PERSONS WHERE ID_PERSON = " + c1TextBox1.Text.Trim();
                    else                            //или же по фамилии и пофиг, если там буквы в перемешку с цифрами, потому что в таком случаем запрос просто ничего не найдет
                        sql = $"SELECT COUNT(*) FROM PERSONS WHERE SURNAME = \"" + c1TextBox1.Text.Trim() + "\"";

                    connection.Open();
                    SqliteCommand command = new SqliteCommand(sql, connection);
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows) // если есть данные
                        {
                            while (reader.Read())   // построчно считываем данные
                            {
                                SqlRowCount = reader.GetInt32(0);
                            }
                        }
                    }
                }
                if (SqlRowCount > 0)
                {
                    Emp_Search_res = new int[SqlRowCount];
                    using (var connection = new SqliteConnection("Data Source=KeysHolder.db"))
                    {
                        string sql = "";
                        if (IdSearch(c1TextBox1.Text))  //если ищем по айди
                            sql = "SELECT * FROM PERSONS WHERE ID_PERSON = " + c1TextBox1.Text.Trim();
                        else                            //или же по фамилии и пофиг, если там буквы в перемешку с цифрами, потому что в таком случаем запрос просто ничего не найдет
                            sql = "SELECT * FROM PERSONS WHERE SURNAME = \"" + c1TextBox1.Text.Trim() + "\"";
                        int i = 0;

                        connection.Open();
                        SqliteCommand command = new SqliteCommand(sql, connection);
                        using (SqliteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows) // если есть данные
                            {
                                while (reader.Read())   // построчно считываем данные
                                {
                                    Emp_Search_res[i++] = reader.GetInt32(0);
                                    listBox1.Items.Add($"{reader.GetString(2)} {reader.GetString(1)} {reader.GetString(3)} | {reader.GetString(4)}");
                                    if (reader.GetValue(6).GetType().FullName != "System.DBNull")
                                        DBImage = new DBImage(reader.GetInt32(0), //id
                                                              reader.GetInt32(0).ToString() + " " + reader.GetString(2), //id (string)
                                                              reader.GetString(2) + " " + reader.GetString(1) + " " + reader.GetString(3), //ФИО
                                                      (byte[])reader.GetValue(6)); //Фото
                                    else
                                        DBImage = new DBImage(reader.GetInt32(0), //id
                                                              reader.GetInt32(0).ToString() + " " + reader.GetString(2), //id (string)
                                                              reader.GetString(2) + " " + reader.GetString(1) + " " + reader.GetString(3), //ФИО
                                                              null); // БЕЗ Фото
                                }
                            }
                        }
                    }
                    if (DBImage.Data != null)
                        using (FileStream fs = new FileStream("..\\..\\Resources\\" + DBImage.FileName + ".jpg", FileMode.OpenOrCreate))
                        {
                            fs.Write(DBImage.Data, 0, DBImage.Data.Length);
                            fs.Close();
                            fs.Dispose();
                        }
                    listBox1.SelectedIndex = 0;
                }
                else
                {
                    //Приводим инфу к дефолту
                    c1Label1.Value = "Сотрудник не найден в базе";
                    photoBox.Image = Image.FromFile("..\\..\\Resources\\error.jpg");
                    Flabel.Text = "Фамилия";
                    Ilabel.Text = "Имя";
                    Olabel.Text = "Отчество";
                    Plabel.Text = "Должность";
                }
                //Переключаем на инфу о сотруднике
                CamEmpGroup.Text = "Информация по сотруднику";
                cameraBox.Visible = false;
                camera = false;
                photoBox.Visible = true;
                Flabel.Visible = true;
                Ilabel.Visible = true;
                Olabel.Visible = true;
                Plabel.Visible = true;
                CamEmpSwitch.Text = "Камера";
            }
        }


        private void c1TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { SearchBtn_Click(sender, e); }
        }
        private void c1TextBox1_Enter(object sender, EventArgs e)
        {
            { if (c1TextBox1.Text =="Введите ID или Фамилию") c1TextBox1.Text = ""; }
        }
        private void c1TextBox1_Leave(object sender, EventArgs e)
        {
            { if (c1TextBox1.Text == "") c1TextBox1.Text = "Введите ID или Фамилию"; }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DBImage.Data != null) //если есть фотка
                photoBox.Image = Image.FromFile("..\\..\\Resources\\"+DBImage.FileName+".jpg");
            else                      //если нет фотки
                photoBox.Image = Image.FromFile("..\\..\\Resources\\error.jpg");

            string[] FIO = DBImage.Title.Split(' ');
            Flabel.Text = FIO[0];
            Ilabel.Text = FIO[1];
            Olabel.Text = FIO[2];
            Plabel.Text = listBox1.Items[listBox1.SelectedIndex].ToString().Remove(0, listBox1.Items[listBox1.SelectedIndex].ToString().IndexOf("|") + 2);

            c1Label1.Value = "Выбран сотрудник\n" + listBox1.Items[listBox1.SelectedIndex] + "\n\nПросканируйте QR ключа";
            I_have_employee_id = true;
            Emp_id = Emp_Search_res[listBox1.SelectedIndex];
            EmpSkanLabel.Text = "Выбран сотрудник " + Emp_id.ToString();
        }

        private void Status_timer_Tick(object sender, EventArgs e)
        {
            if (status_time-- == 0)
            {
                Status_label.Text = "Статус доступа";
                Status_label.ForeColor = Color.Black;
                status_time = 5;
                Status_timer.Enabled = false;
            }
        }

        bool isOnBase = true;
        private void Cleaner_btn_Click(object sender, EventArgs e)
        {
            
            Random rnd = new Random();
            int time = rnd.Next(0, 1);
            if (isOnBase)
            {
                var reuslt = MessageBox.Show("Взять ключи?", "Подтвердите действие", MessageBoxButtons.YesNo);
                if (reuslt == DialogResult.No) return;
                isOnBase = false;
                Cleaner_btn.BackColor = Color.Red;
                if(time == 0)
                {
                    // ОТДАТЬ ПРВУЮ ПОЛОВИНУ КЛЮЧЕЙ ИЗ БАЗЫ
                } 
                else
                {
                    // ОТДАТЬ ВТОРУЮ ПОЛОВИНУ КЛЮЧЕЙ
                }
            } 
            else
            {
                var reuslt = MessageBox.Show("Вернуть ключи?", "Подтвердите действие", MessageBoxButtons.YesNo);
                if (reuslt == DialogResult.No) return;
                Cleaner_btn.BackColor = Color.Green;
                isOnBase = true;
                if (time == 0)
                {
                    // ВЕРНУТЬ ПРВУЮ ПОЛОВИНУ КЛЮЧЕЙ ИЗ БАЗЫ
                }
                else
                {
                    // ВЕРНУТЬ ВТОРУЮ ПОЛОВИНУ КЛЮЧЕЙ
                }
            }
        }

        private void c1Button1_Click(object sender, EventArgs e)
        {

        }

        //скейл↓
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
     //       HandyAddyGroupBox.Width = (int)(this.Width * 0.667);
     //       HandyAddyGroupBox.Location = new Point(HandyAddyGroupBox.Location.X, this.Height - HandyAddyGroupBox.Height - 49);
        }

    }
}

