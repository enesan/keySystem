using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using System.IO;
using System.Drawing;

namespace Key_systemAlpha
{
    public partial class Boss : Form
    {

        private int WIDTH;
        private int HEIGHT;
        private int countOfLabels = 5;
        public Boss()
        {
            InitializeComponent();
        }
        Form form = new InitForm();
        List<DBImage> DBImages = new List<DBImage>();

        private void Boss_Load(object sender, EventArgs e)
        {
        
            Width = 1070;
            Height = 680;
            WIDTH = Width;
            HEIGHT = Height;
            c1Label1.Value = "Поле:";
            c1Label6.Value = "Добавить что-то";
             LabelsAndTextsVisability(1);

            

            c1TextBox1.Enabled = false;
            btnAdd.Enabled = false;

            c1DockingTab1.SelectedIndex = 0;
            History_table();
            Persons_table();
            Keys_table();

            // разещения элементов
            c1DockingTab1.Location = new Point(22, 23);
            //c1DockingTab1.Size = new Size(845, 640);
            // фиксируем лейбочки относительно табдокера
            c1Label1.Location = new Point(c1DockingTab1.Location.X + c1DockingTab1.Width + 44, c1DockingTab1.Location.Y + 68);
            c1Label2.Location = new Point(c1Label1.Location.X, c1Label1.Location.Y + 80);
            c1Label3.Location = new Point(c1Label1.Location.X, c1Label2.Location.Y + 80);
            c1Label4.Location = new Point(c1Label1.Location.X, c1Label3.Location.Y + 80);
            c1Label5.Location = new Point(c1Label1.Location.X, c1Label4.Location.Y + 80);
            c1TextBox1.Location = new Point(c1Label1.Location.X + 190, c1Label1.Location.Y);
            c1TextBox2.Location = new Point(c1TextBox1.Location.X, c1Label2.Location.Y);
            c1TextBox3.Location = new Point(c1TextBox1.Location.X, c1Label3.Location.Y);
            c1TextBox4.Location = new Point(c1TextBox1.Location.X, c1Label4.Location.Y);
            c1TextBox5.Location = new Point(c1TextBox1.Location.X, c1Label5.Location.Y);

            btnAdd.Size = new Size(350, 80);
            MoveControl(c1Label1, btnAdd, 20, c1TextBox1.Height + 40);

        }

        public void History_table()
        {
            using (var connection = new SqliteConnection("Data Source=KeysHolder.db"))
            {
                string sql = "SELECT COUNT(*) FROM KEYS_TO_PERSONS WHERE ID_KP > 0";
                connection.Open();
                SqliteCommand command = new SqliteCommand(sql, connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())   // построчно считываем данные
                        {
                            c1FlexGrid1.Rows.Count = reader.GetInt32(0) + 1;    //определяе количество строк для вывода
                        }
                    }
                }

                // ***** Здесь править, потому что количество столбцов теперь = 6 ***********
                c1FlexGrid1.Cols.Count = 5;
                sql = "SELECT * FROM KEYS_TO_PERSONS  WHERE ID_KP > 0";
                command = new SqliteCommand(sql, connection);
                int i = 1;
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())   // построчно считываем данные
                        {
                            int j = 0;
                            int pk_id = reader.GetInt32(0);
                            int kid = reader.GetInt32(1);
                            int pid = reader.GetInt32(2);
                            string date = reader.GetString(3);
                            string type = reader.GetString(4);

                            //Можно, конечно и покрасивше сделать, но пока и так пойдет
                            c1FlexGrid1[i, j++] = pk_id;
                            c1FlexGrid1[i, j++] = kid;
                            c1FlexGrid1[i, j++] = pid;
                            c1FlexGrid1[i, j++] = date;
                            c1FlexGrid1[i, j++] = type;
                            i++;
                        }
                    }
                }
            }
        }

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
                            c1FlexGrid2.Rows.Count = reader.GetInt32(0) + 1;
                        }
                    }
                }

                c1FlexGrid2.Cols.Count = 6;
                sql = "SELECT * FROM PERSONS where ID_PERSON > 0";
                command = new SqliteCommand(sql, connection);
                int i = 1;
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())   // построчно считываем данные
                        {
                            int j = 0;
                            int p_id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            string sname = reader.GetString(2);
                            string patron = reader.GetString(3);
                            string pos = reader.GetString(4);
                            string Bday = reader.GetString(5);
                            byte[] data = (byte[])reader.GetValue(6);

                            //Можно, конечно и покрасивше сделать, но пока и так пойдет
                            c1FlexGrid2[i, j++] = p_id;
                            c1FlexGrid2[i, j++] = name;
                            c1FlexGrid2[i, j++] = sname;
                            c1FlexGrid2[i, j++] = patron;
                            c1FlexGrid2[i, j++] = pos;
                            c1FlexGrid2[i, j++] = Bday;
                            i++;

                            DBImage image = new DBImage(p_id, p_id.ToString(), name + " " + sname + " " + patron, data);
                            DBImages.Add(image);
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
                            c1FlexGrid3.Rows.Count = reader.GetInt32(0) + 1;
                        }
                    }
                }

                sql = "SELECT * FROM KEYS where ID_KEY > 0";
                command = new SqliteCommand(sql, connection);
                int i = 1;
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())   // построчно считываем данные
                        {
                            int j = 0;
                            int Key_id = reader.GetInt32(0);
                            string cabNum = reader.GetString(1);
                            int taken = reader.GetInt32(2);


                            //Можно, конечно и покрасивше сделать, но пока и так пойдет
                            c1FlexGrid3[i, j++] = Key_id;
                            c1FlexGrid3[i, j++] = cabNum;
                            c1FlexGrid3[i, j++] = taken == 0 ? "На посту" : "Забран";
                            i++;
                        }
                    }
                }
            }
        }

        private void Boss_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
            this.Dispose();
        }

        private void c1DockingTab1_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1FlexGrid1.AutoSizeCols();
            switch (c1DockingTab1.SelectedIndex)
            {
                case 0:
                    {

                        c1Label1.Value = "Поле:";
                        c1Label6.Value = "Добавить что-то";

                        c1TextBox1.Enabled = false;
                        btnAdd.Enabled = false;

                        LabelsAndTextsVisability(1);
                        MoveControl(c1Label1, btnAdd, 20, c1TextBox1.Height + 40);
                     //   btnAdd.Size = new Size(350, 80);
                        break;
                    }
                case 1:
                    {
                        c1Label1.Value = "Фамилия:";
                        c1Label2.Value = "Имя:";
                        c1Label3.Value = "Отчество:";
                        c1Label4.Value = "Должность:";
                        c1Label5.Value = "Дата рождения:";
                        c1Label6.Value = "Добавить сотрудника";
                        c1TextBox1.Enabled = true;
                        btnAdd.Enabled = true;
                        LabelsAndTextsVisability(5);
                        MoveControl(c1Label5, btnAdd, 20, c1TextBox5.Height + 40);
                     //   btnAdd.Size = new Size(350, 80);
                        break;
                    }
                case 2:
                    {
                        c1Label6.Value = "Добавить ключ";
                        c1Label1.Value = "№ помещения:";
                        c1Label2.Value = "Статус ключа:";
                        c1TextBox1.Enabled = true;
                        btnAdd.Enabled = true;
                        c1TextBox3.Hide();
                        c1Label3.Hide();

                        LabelsAndTextsVisability(3);
                        MoveControl(c1Label2, btnAdd, 20, c1TextBox2.Height + 35);
                     //   btnAdd.Size = new Size(350, 80);

                        break;
                    }
                case 3:
                    {
                        c1Label1.Value = "Id ключа:";
                        c1Label2.Value = "Id сотрудника:";
                        c1Label3.Value = "Примечание:";
                        c1Label6.Value = "Добавить доступ";
                        c1TextBox1.Enabled = true;
                        btnAdd.Enabled = true;

                        c1Label4.Hide();
                        c1TextBox4.Hide();
                        LabelsAndTextsVisability(4);
                        MoveControl(c1Label3, btnAdd, 20, c1TextBox3.Height + 40);
                      //  btnAdd.Size = new Size(350, 80);
                        break;
                    }
                case 4:
                    {
                        c1Label1.Value = "Фамилия:";
                        c1Label2.Value = "Имя:";
                        c1Label3.Value = "Отчество:";
                        c1Label4.Value = "Логин:";
                        c1Label5.Value = "Пароль:";
                        c1Label6.Value = "Добавить охранника";
                        c1TextBox1.Enabled = true;
                        btnAdd.Enabled = true;
                        LabelsAndTextsVisability(5);
                        MoveControl(c1Label5, btnAdd, 20, c1TextBox5.Height + 40);
                       // btnAdd.Size = new Size(350, 80);
                        break;
                    }
            }
        }

        private void MoveControl(Control source, Control target, int offsetX = 0, int offsetY = 0)
        {
            int x = source.Location.X;
            int y = source.Location.Y;
            target.Location = new Point(x + offsetX, y + offsetY);
        }

        private void LabelsAndTextsVisability(int amountOfVisible)
        {
            for (int i = countOfLabels - 1; i > amountOfVisible; i--)
            {
                string label = "c1Label" + i;
                string textBox = "c1TextBox" + i;
                Control controlLabel = c1Sizer1.Controls.Find(label, false)[0];
                Control controlTextBox = c1Sizer1.Controls.Find(textBox, false)[0];
                controlLabel.Hide();
                controlTextBox.Hide();
            }
            c1Label5.Hide();
            c1TextBox5.Hide();

            for (int i = 2; i < amountOfVisible; i++)
            {
                string label = "c1Label" + i;
                string textBox = "c1TextBox" + i;
                Control controlLabel = c1Sizer1.Controls.Find(label, false)[0];
                Control controlTextBox = c1Sizer1.Controls.Find(textBox, false)[0];
                 controlLabel.Show();
                 controlTextBox.Show();
                if (amountOfVisible == 5)
                {
                    c1Label5.Show();
                    c1TextBox5.Show();
                }
            }
        }

        private void Boss_Resize(object sender, EventArgs e)
        {

           // c1Label6.Text = "x: " + Width.ToString() + " y: " + Height.ToString() ;
        }

        private void c1Sizer1_Click(object sender, EventArgs e)
        {

        }

        private void c1FlexGrid1_Click(object sender, EventArgs e)
        {

        }
    }
}
