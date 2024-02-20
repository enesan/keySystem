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

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
        List<DBImage> DBImages = new List<DBImage>();

        // Запусти приложение, найди свою комеру в комбобоксе
        // поставь сюда индекс своей камеры
        int selectedIndex = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
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

                captureDevice = new VideoCaptureDevice(filterInfoCollection[selectedIndex].MonikerString);
                captureDevice.NewFrame += CaptureDevice_NewFrame;
                captureDevice.Start();
                timer.Start();
                cboDevice.SelectedIndex = selectedIndex;

            }

            //Начало части Вали
            Keys_To_Persons_table();
            Persons_table();
            Keys_table();
            //Конец части Вали

        }

        //Выгрузка Истории в gdv
        public void Keys_To_Persons_table()
        {
            using (var connection = new SqliteConnection("Data Source=KeysHolder.db"))
            {
                string sql = "SELECT COUNT(*) FROM KEYS_TO_PERSONS";
                connection.Open();
                SqliteCommand command = new SqliteCommand(sql, connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())   // построчно считываем данные
                        {
                            dataGridView1.RowCount = reader.GetInt32(0);
                        }
                    }
                }

                dataGridView1.ColumnCount = 5;
                sql = "SELECT * FROM KEYS_TO_PERSONS";
                command = new SqliteCommand(sql, connection);
                int j = 0;
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())   // построчно считываем данные
                        {
                            int i = 0;
                            int pk_id = reader.GetInt32(0);
                            int kid = reader.GetInt32(1);
                            int pid = reader.GetInt32(2);
                            string date = reader.GetString(3);
                            string type = reader.GetString(4);


                            //Можно, конечно и покрасивше сделать, но пока и так пойдет
                            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dataGridView1[i++, j].Value = pk_id;
                            dataGridView1[i++, j].Value = kid;
                            dataGridView1[i++, j].Value = pid;
                            dataGridView1[i++, j].Value = date;
                            dataGridView1[i++, j].Value = type;
                            j++;
                        }
                    }
                }
            }
        }

        //Выгрузка Сотрудников в gdv и combobox'ы
        public void Persons_table()
        {
            using (var connection = new SqliteConnection("Data Source=KeysHolder.db"))
            {
                string sql = "SELECT COUNT(*) FROM PERSONS where ID_PERSON > 0";
                connection.Open();
                SqliteCommand command = new SqliteCommand(sql, connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())   // построчно считываем данные
                        {
                            dataGridView2.RowCount = reader.GetInt32(0);
                        }
                    }
                }

                dataGridView2.ColumnCount = 6;
                sql = "SELECT * FROM PERSONS where ID_PERSON > 0";
                command = new SqliteCommand(sql, connection);
                int j = 0;
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())   // построчно считываем данные
                        {
                            int i = 0;
                            int p_id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            string sname = reader.GetString(2);
                            string patron = reader.GetString(3);
                            string pos = reader.GetString(4);
                            string Bday = reader.GetString(5);
                            byte[] data = (byte[])reader.GetValue(6);

                            //Можно, конечно и покрасивше сделать, но пока и так пойдет
                            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dataGridView2[i++, j].Value = p_id;
                            dataGridView2[i++, j].Value = name;
                            dataGridView2[i++, j].Value = sname;
                            dataGridView2[i++, j].Value = patron;
                            dataGridView2[i++, j].Value = pos;
                            dataGridView2[i++, j].Value = Bday;
                            Pers_combo.Items.Add(p_id);

                            DBImage image = new DBImage(p_id, p_id.ToString(), name + " " + sname + " " + patron, data);
                            DBImages.Add(image);
                            j++;
                        }
                    }
                }

                if (DBImages.Count > 0)
                {
                    using (FileStream fs = new FileStream(DBImages[0].FileName, FileMode.OpenOrCreate))
                    {
                        fs.Write(DBImages[0].Data, 0, DBImages[0].Data.Length);

                    }
                }
            }
        }

        //Выгрузка Ключей в gdv и combobox'ы
        public void Keys_table()
        {
            using (var connection = new SqliteConnection("Data Source=KeysHolder.db"))
            {
                string sql = "SELECT COUNT(*) FROM KEYS  where ID_KEY > 0";
                connection.Open();
                SqliteCommand command = new SqliteCommand(sql, connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())   // построчно считываем данные
                        {
                            dataGridView4.RowCount = reader.GetInt32(0);
                        }
                    }
                }

                dataGridView4.ColumnCount = 4;
                sql = "SELECT * FROM KEYS where ID_KEY > 0 and count > taken";
                command = new SqliteCommand(sql, connection);
                int j = 0;
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())   // построчно считываем данные
                        {
                            int i = 0;
                            int Key_id = reader.GetInt32(0);
                            string cabNum = reader.GetString(1);
                            int count = reader.GetInt32(2);
                            int taken = reader.GetInt32(3);


                            //Можно, конечно и покрасивше сделать, но пока и так пойдет
                            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dataGridView4[i++, j].Value = Key_id;
                            dataGridView4[i++, j].Value = cabNum;
                            dataGridView4[i++, j].Value = count;
                            dataGridView4[i++, j].Value = taken;
                            Keys_combo.Items.Add(Key_id);
                            j++;
                        }
                    }
                }
            }
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            cameraBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //тут будет вывод инфы о сотруднике

        }

        private void cboDevice_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (captureDevice.IsRunning) captureDevice.Stop();
            timer.Stop();
            captureDevice = new VideoCaptureDevice(filterInfoCollection[selectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            timer.Start();
            captureDevice.Start();
            selectedIndex = cboDevice.SelectedIndex;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
            {
                captureDevice.Stop();
            }
        }

        private void Sname_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Surname_Search_Click(sender, e);
        }

        private void Surname_Search_Click(object sender, EventArgs e)
        {
            List<string> snames = new List<string>();
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                if (dataGridView2[2, i].Value.ToString() == Sname_textbox.Text)
                {
                    snames.Add($"{dataGridView2[0, i].Value.ToString()} {dataGridView2[1, i].Value.ToString()} {dataGridView2[2, i].Value.ToString()} {dataGridView2[3, i].Value.ToString()} {dataGridView2[4, i].Value.ToString()} {dataGridView2[5, i].Value.ToString()}");
                }
            }
            if (snames.Count > 0)
            {
                string res = "";
                for (int i = 0; i < snames.Count; i++)
                {
                    res += snames[i] + "\n";
                }
                MessageBox.Show($"Сотрудник(-и) с фамилией {Sname_textbox.Text}:\n{res}");
            }
            else MessageBox.Show("Сотрудника с такой фамилией нет в базе");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (cameraBox.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)cameraBox.Image);
                if (result != null)
                {
                    string code_id = result.ToString().Split(new char[] { ' ' })[0];

                    if (Int32.TryParse(code_id, out int id))
                    {

                        if (code_id.Length == 3)
                        {
                            try
                            {
                                Keys_combo.SelectedIndex = Keys_combo.FindString(result.ToString());
                                photoBox.Image = Image.FromFile(
                                       Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Resources\\key.jpg");
                                infoLabel.Text = "Ключ " + code_id;
                            }
                            catch (Exception)
                            {
                                photoBox.Image = Image.FromFile(
                                       Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Resources\\error.jpg");
                                infoLabel.Text = "Код ключа не найден в базе.\n";
                            }
                        }
                        else if (code_id.Length == 5)
                        {
                            try
                            {
                                Pers_combo.SelectedIndex = Pers_combo.FindString(result.ToString());
                                photoBox.Image = Image.FromFile(
                                   Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Resources\\" + code_id + ".jpg");
                                // изменить на данные сорудника из бд
                                infoLabel.Text = "Сотрудник " + code_id;
                            }
                            catch (FileNotFoundException ex)
                            {
                                photoBox.Image = Image.FromFile(
                                    Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Resources\\no_photo.jpg");
                                infoLabel.Text = "Здесь всё равно надо\n вывести данные того,\n кто взял ключ через \n";
                            }
                            // Здесь нужно обработать SQL экзепшн, если айди не найден
                            catch (Exception)
                            {
                                photoBox.Image = Image.FromFile(
                                      Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Resources\\error.jpg");
                                infoLabel.Text = "Код сотрудника не найден в базе.\n";
                            }
                        }
                        
                    }
                    else
                    {
                        photoBox.Image = Image.FromFile(
                                 Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Resources\\error.jpg");

                        infoLabel.Text = "Неверный формат кода!";

                    }
                }
            }
        }

        private void Add_Into_History_Click(object sender, EventArgs e)
        {
            using (var con = new SqliteConnection("Data Source=KeysHolder.db"))
            {
                con.Open();

                SqliteCommand com = new SqliteCommand();
                com.Connection = con;
                com.CommandText = @"INSERT INTO KEYS_TO_PERSONS (ID_KEY, ID_PERSON, DATE_TIME, TYPE) VALUES (@b,@c,@d,@e)";
                com.Parameters.Add(new SqliteParameter("@b", Convert.ToInt32(Keys_combo.SelectedItem.ToString())));
                com.Parameters.Add(new SqliteParameter("@c", Convert.ToInt32(Pers_combo.SelectedItem.ToString())));
                com.Parameters.Add(new SqliteParameter("@d", DateTime.Now));
                com.Parameters.Add(new SqliteParameter("@e", "Вручную"));
                com.ExecuteNonQuery();
            }
            Keys_To_Persons_table();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            new InitForm().Show();
        }
    }

}
