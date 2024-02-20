using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using System.IO;

namespace Key_systemAlpha
{
    public partial class Boss : Form
    {
        public Boss()
        {
            InitializeComponent();
        }

        List<DBImage> DBImages = new List<DBImage>();
        private void Boss_Load(object sender, EventArgs e)
        {
            Keys_To_Persons_table();
            Persons_table();
            Keys_table();
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
                            c1FlexGrid1.Rows.Count = reader.GetInt32(0);
                        }
                    }
                }

                // ***** Здесь править, потому что количество столбцов теперь = 6 ***********
                c1FlexGrid1.Cols.Count = 5;
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
                            //************ Исправить, количество столбцов изменилось *********************
                            // ** Я везде убрал .value, так как там, вроде, содержимое каждой ячейки по дефолту является object
                            c1FlexGrid1.AutoSizeCols();
                            c1FlexGrid1[i++, j] = pk_id;
                            c1FlexGrid1[i++, j] = kid;
                            c1FlexGrid1[i++, j] = pid;
                            c1FlexGrid1[i++, j] = date;
                            c1FlexGrid1[i++, j] = type;
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
                            c1FlexGrid2.Rows.Count = reader.GetInt32(0);
                        }
                    }
                }

                c1FlexGrid2.Cols.Count = 6;
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
                            c1FlexGrid2.AutoSizeCols();
                            c1FlexGrid2[i++, j] = p_id;
                            c1FlexGrid2[i++, j] = name;
                            c1FlexGrid2[i++, j] = sname;
                            c1FlexGrid2[i++, j] = patron;
                            c1FlexGrid2[i++, j] = pos;
                            c1FlexGrid2[i++, j] = Bday;

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
                            c1FlexGrid3.Rows.Count = reader.GetInt32(0);
                        }
                    }
                }

                c1FlexGrid3.Cols.Count = 4;
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
                            c1FlexGrid3.AutoSizeCols();
                            c1FlexGrid3[i++, j] = Key_id;
                            c1FlexGrid3[i++, j] = cabNum;
                            c1FlexGrid3[i++, j] = count;
                            c1FlexGrid3[i++, j] = taken;
                            j++;
                        }
                    }
                }
            }
        }

        private void Boss_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            new InitForm().Show();
        }

        private void c1DockingTab1_SelectedTabChanged(object sender, EventArgs e)
        {
            switch (c1DockingTab1.SelectedIndex)
            {
                case 1:
                    {
                        c1Label1.Value = "Фамилия:";
                        c1Label2.Value = "Имя:";
                        c1Label3.Value = "Отчество:";
                        c1Label4.Value = "должность:";
                        c1Label5.Value = "Дата рождения:";
                        c1Label7.Value = "Добавить сотрудника";
                        break;
                    }
                case 2:
                    {
                        c1Label1.Value = "Фамилия:";
                        c1Label2.Value = "Имя:";
                        c1Label3.Value = "Отчество:";
                        c1Label4.Value = "должность:";
                        c1Label5.Value = "Дата рождения:";
                        c1Label7.Value = "Добавить сотрудника";
                        break;
                    }
                case 3:
                    {
                        c1Label7.Value = "Добавить ключ";
                        c1Label1.Value = "Номер помещения"; 
                        break;
                    }
                case 4:
                    {
                        c1Label1.Value = "Добавить сотрудника";
                        c1Label7.Value = "Добавить ";
                        break;
                    }
            }

        }
    }
}
