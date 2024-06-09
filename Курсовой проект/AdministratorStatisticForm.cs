using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовой_проект
{
    public partial class AdministratorStatisticForm : Form
    {
        public AdministratorStatisticForm()
        {
            InitializeComponent();


            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
            {
                connection.Open();

                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = $"SELECT * FROM staff;";
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    SelectStaffComboBox.Items.Add(reader["staff_name"]);

                }

                SelectStaffComboBox.Items.Add("Всего");
            }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (SelectStaffComboBox.Text == "Всего")
            {
                // Всего заказов за день
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command = new NpgsqlCommand();
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = $"SELECT COUNT(*)\r\nFROM (\r\n  SELECT COUNT(*)\r\n  FROM sale \r\n  WHERE DATE(sale_date) = CURRENT_DATE\r\n  GROUP BY sale_date\r\n);";
                    NpgsqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        label20.Text = Convert.ToString(reader["count"]);
                    }
                }
                // Стоимость всех заказов за день
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command1 = new NpgsqlCommand();
                    command1.Connection = connection;
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = $"SELECT SUM(menu_food_price)\r\nFROM menu\r\nJOIN sale ON sale_menu = menu_id\r\nWHERE DATE(sale_date) = CURRENT_DATE;";
                    NpgsqlDataReader reader1 = command1.ExecuteReader();

                    while (reader1.Read())
                    {
                        label40.Text = Convert.ToString(reader1["sum"]);
                    }
                }


                // Всего заказов за неделю
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command = new NpgsqlCommand();
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = $"SELECT COUNT(*)\r\nFROM (\r\n  SELECT COUNT(*)\r\n  FROM sale \r\n  WHERE DATE_PART('week', sale_date) = DATE_PART('week', CURRENT_DATE) \r\n  GROUP BY sale_date\r\n);";
                    NpgsqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        label24.Text = Convert.ToString(reader["count"]);
                    }
                }


                // Стоимость всех заказов за неделю
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command1 = new NpgsqlCommand();
                    command1.Connection = connection;
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = $"SELECT SUM(menu_food_price)\r\nFROM menu\r\nJOIN sale ON sale_menu = menu_id\r\nWHERE DATE_PART('week', sale_date) = DATE_PART('week', CURRENT_DATE);";
                    NpgsqlDataReader reader1 = command1.ExecuteReader();

                    while (reader1.Read())
                    {
                        label43.Text = Convert.ToString(reader1["sum"]);
                    }
                }

                // Всего заказов за месяц
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command = new NpgsqlCommand();
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = $"SELECT COUNT(*)\r\nFROM (\r\n  SELECT COUNT(*)\r\n  FROM sale \r\n  WHERE DATE_PART('month', sale_date) = DATE_PART('month', CURRENT_DATE) \r\n  GROUP BY sale_date\r\n);";
                    NpgsqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        label23.Text = Convert.ToString(reader["count"]);
                    }
                }

                // Стоимость всех заказов за месяц
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command1 = new NpgsqlCommand();
                    command1.Connection = connection;
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = $"SELECT SUM(menu_food_price)\r\nFROM menu\r\nJOIN sale ON sale_menu = menu_id\r\nWHERE DATE_PART('month', sale_date) = DATE_PART('month', CURRENT_DATE);";
                    NpgsqlDataReader reader1 = command1.ExecuteReader();

                    while (reader1.Read())
                    {
                        label42.Text = Convert.ToString(reader1["sum"]);
                    }
                }

                // Всего заказов
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command = new NpgsqlCommand();
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = $"SELECT COUNT(*)\r\nFROM (\r\n  SELECT COUNT(*)\r\n  FROM sale \r\n   GROUP BY sale_date\r\n);";
                    NpgsqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        label22.Text = Convert.ToString(reader["count"]);
                    }
                }

                // Стоимость всех заказов
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command1 = new NpgsqlCommand();
                    command1.Connection = connection;
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = $"SELECT SUM(menu_food_price)\r\nFROM menu\r\nJOIN sale ON sale_menu = menu_id;";
                    NpgsqlDataReader reader1 = command1.ExecuteReader();

                    while (reader1.Read())
                    {
                        label41.Text = Convert.ToString(reader1["sum"]);
                    }
                }



                // Количество борщей
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command1 = new NpgsqlCommand();
                    command1.Connection = connection;
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = $"SELECT COUNT(sale_menu)\r\nFROM sale\r\nWHERE sale_menu = 1;";
                    NpgsqlDataReader reader1 = command1.ExecuteReader();

                    while (reader1.Read())
                    {
                        label21.Text = Convert.ToString(reader1["count"]);
                    }
                }


                // Количество пельменей
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command1 = new NpgsqlCommand();
                    command1.Connection = connection;
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = $"SELECT COUNT(sale_menu)\r\nFROM sale\r\nWHERE sale_menu = 2;";
                    NpgsqlDataReader reader1 = command1.ExecuteReader();

                    while (reader1.Read())
                    {
                        label31.Text = Convert.ToString(reader1["count"]);
                    }
                }



                // Количество оливье
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command1 = new NpgsqlCommand();
                    command1.Connection = connection;
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = $"SELECT COUNT(sale_menu)\r\nFROM sale\r\nWHERE sale_menu = 3;";
                    NpgsqlDataReader reader1 = command1.ExecuteReader();

                    while (reader1.Read())
                    {
                        label30.Text = Convert.ToString(reader1["count"]);
                    }
                }


                // Количество блинов с красной икрой
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command1 = new NpgsqlCommand();
                    command1.Connection = connection;
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = $"SELECT COUNT(sale_menu)\r\nFROM sale\r\nWHERE sale_menu = 4;";
                    NpgsqlDataReader reader1 = command1.ExecuteReader();

                    while (reader1.Read())
                    {
                        label29.Text = Convert.ToString(reader1["count"]);
                    }
                }


                // Количество шашлыков со свининой
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command1 = new NpgsqlCommand();
                    command1.Connection = connection;
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = $"SELECT COUNT(sale_menu)\r\nFROM sale\r\nWHERE sale_menu = 5;";
                    NpgsqlDataReader reader1 = command1.ExecuteReader();

                    while (reader1.Read())
                    {
                        label28.Text = Convert.ToString(reader1["count"]);
                    }
                }


                // Количество салатов цезарь
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command1 = new NpgsqlCommand();
                    command1.Connection = connection;
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = $"SELECT COUNT(sale_menu)\r\nFROM sale\r\nWHERE sale_menu = 6;";
                    NpgsqlDataReader reader1 = command1.ExecuteReader();

                    while (reader1.Read())
                    {
                        label27.Text = Convert.ToString(reader1["count"]);
                    }
                }


                // Количество пирогов с вишней
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command1 = new NpgsqlCommand();
                    command1.Connection = connection;
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = $"SELECT COUNT(sale_menu)\r\nFROM sale\r\nWHERE sale_menu = 7;";
                    NpgsqlDataReader reader1 = command1.ExecuteReader();

                    while (reader1.Read())
                    {
                        label26.Text = Convert.ToString(reader1["count"]);
                    }
                }


                // Количество котлет по-киевски
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command1 = new NpgsqlCommand();
                    command1.Connection = connection;
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = $"SELECT COUNT(sale_menu)\r\nFROM sale\r\nWHERE sale_menu = 8;";
                    NpgsqlDataReader reader1 = command1.ExecuteReader();

                    while (reader1.Read())
                    {
                        label25.Text = Convert.ToString(reader1["count"]);
                    }
                }


                // Количество окрошек
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command1 = new NpgsqlCommand();
                    command1.Connection = connection;
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = $"SELECT COUNT(sale_menu)\r\nFROM sale\r\nWHERE sale_menu = 9;";
                    NpgsqlDataReader reader1 = command1.ExecuteReader();

                    while (reader1.Read())
                    {
                        label34.Text = Convert.ToString(reader1["count"]);
                    }
                }


                // Количество мант
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command1 = new NpgsqlCommand();
                    command1.Connection = connection;
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = $"SELECT COUNT(sale_menu)\r\nFROM sale\r\nWHERE sale_menu = 10;";
                    NpgsqlDataReader reader1 = command1.ExecuteReader();

                    while (reader1.Read())
                    {
                        label33.Text = Convert.ToString(reader1["count"]);
                    }
                }

                // Количество лимонада
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command1 = new NpgsqlCommand();
                    command1.Connection = connection;
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = $"SELECT COUNT(sale_menu)\r\nFROM sale\r\nWHERE sale_menu = 11;";
                    NpgsqlDataReader reader1 = command1.ExecuteReader();

                    while (reader1.Read())
                    {
                        label32.Text = Convert.ToString(reader1["count"]);
                    }
                }


                // Количество воды
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command1 = new NpgsqlCommand();
                    command1.Connection = connection;
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = $"SELECT COUNT(sale_menu)\r\nFROM sale\r\nWHERE sale_menu = 12;";
                    NpgsqlDataReader reader1 = command1.ExecuteReader();

                    while (reader1.Read())
                    {
                        label44.Text = Convert.ToString(reader1["count"]);
                    }
                }
            }

            // Статистика лично по каждому официанту
            else
            {
                // Всего заказов за день
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command = new NpgsqlCommand();
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = $"SELECT COUNT(*)\r\nFROM (SELECT COUNT(*) \r\n\t  FROM sale \r\n\t  JOIN staff ON sale_staff = staff_id\r\n\t  WHERE DATE(sale_date) = CURRENT_DATE AND staff_name = '{SelectStaffComboBox.Text}'\r\n\t  GROUP BY sale_date);";
                    NpgsqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        label20.Text = Convert.ToString(reader["count"]);
                    }
                }
                // Стоимость всех заказов за день
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command1 = new NpgsqlCommand();
                    command1.Connection = connection;
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = $"SELECT SUM(menu_food_price) \r\nFROM menu \r\nJOIN sale ON sale_menu = menu_id \r\nJOIN staff ON sale_staff = staff_id\r\nWHERE DATE(sale_date) = CURRENT_DATE AND staff_name = '{SelectStaffComboBox.Text}';";
                    NpgsqlDataReader reader1 = command1.ExecuteReader();

                    while (reader1.Read())
                    {
                        label40.Text = Convert.ToString(reader1["sum"]);
                    }
                }


                // Всего заказов за неделю
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command = new NpgsqlCommand();
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = $"SELECT COUNT(*)\r\nFROM (SELECT COUNT(*) \r\n\t  FROM sale \r\n\t  JOIN staff ON sale_staff = staff_id\r\n\t  WHERE DATE_PART('week', sale_date) = DATE_PART('week', CURRENT_DATE) AND staff_name = '{SelectStaffComboBox.Text}'\r\n\t  GROUP BY sale_date);";
                    NpgsqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        label24.Text = Convert.ToString(reader["count"]);
                    }
                }


                // Стоимость всех заказов за неделю
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command1 = new NpgsqlCommand();
                    command1.Connection = connection;
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = $"SELECT SUM(menu_food_price) \r\nFROM menu \r\nJOIN sale ON sale_menu = menu_id \r\nJOIN staff ON sale_staff = staff_id\r\nWHERE DATE_PART('week', sale_date) = DATE_PART('week', CURRENT_DATE) AND staff_name = '{SelectStaffComboBox.Text}';";
                    NpgsqlDataReader reader1 = command1.ExecuteReader();

                    while (reader1.Read())
                    {
                        label43.Text = Convert.ToString(reader1["sum"]);
                    }
                }

                // Всего заказов за месяц
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command = new NpgsqlCommand();
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = $"SELECT COUNT(*)\r\nFROM (SELECT COUNT(*) \r\n\t  FROM sale \r\n\t  JOIN staff ON sale_staff = staff_id\r\n\t  WHERE DATE_PART('month', sale_date) = DATE_PART('month', CURRENT_DATE) AND staff_name = '{SelectStaffComboBox.Text}'\r\n\t  GROUP BY sale_date);";
                    NpgsqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        label23.Text = Convert.ToString(reader["count"]);
                    }
                }

                // Стоимость всех заказов за месяц
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command1 = new NpgsqlCommand();
                    command1.Connection = connection;
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = $"SELECT SUM(menu_food_price) \r\nFROM menu \r\nJOIN sale ON sale_menu = menu_id \r\nJOIN staff ON sale_staff = staff_id\r\nWHERE DATE_PART('month', sale_date) = DATE_PART('month', CURRENT_DATE) AND staff_name = '{SelectStaffComboBox.Text}';";
                    NpgsqlDataReader reader1 = command1.ExecuteReader();

                    while (reader1.Read())
                    {
                        label42.Text = Convert.ToString(reader1["sum"]);
                    }
                }

                // Всего заказов
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command = new NpgsqlCommand();
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = $"SELECT COUNT(*)\r\nFROM (SELECT COUNT(*) \r\n\t  FROM sale \r\n\t  JOIN staff ON sale_staff = staff_id\r\n\t  WHERE staff_name = '{SelectStaffComboBox.Text}'\r\n\t  GROUP BY sale_date);";
                    NpgsqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        label22.Text = Convert.ToString(reader["count"]);
                    }
                }

                // Стоимость всех заказов
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command1 = new NpgsqlCommand();
                    command1.Connection = connection;
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = $"SELECT SUM(menu_food_price) \r\nFROM menu \r\nJOIN sale ON sale_menu = menu_id \r\nJOIN staff ON sale_staff = staff_id\r\nWHERE staff_name = '{SelectStaffComboBox.Text}';";
                    NpgsqlDataReader reader1 = command1.ExecuteReader();

                    while (reader1.Read())
                    {
                        label41.Text = Convert.ToString(reader1["sum"]);
                    }
                }



                // Количество борщей
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command1 = new NpgsqlCommand();
                    command1.Connection = connection;
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = $"SELECT COUNT(sale_menu) \r\nFROM sale \r\nJOIN staff ON sale_staff = staff_id\r\nWHERE staff_name = '{SelectStaffComboBox.Text}' AND sale_menu = 1;";
                    NpgsqlDataReader reader1 = command1.ExecuteReader();

                    while (reader1.Read())
                    {
                        label21.Text = Convert.ToString(reader1["count"]);
                    }
                }


                // Количество пельменей
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command1 = new NpgsqlCommand();
                    command1.Connection = connection;
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = $"SELECT COUNT(sale_menu) \r\nFROM sale \r\nJOIN staff ON sale_staff = staff_id\r\nWHERE staff_name = '{SelectStaffComboBox.Text}' AND sale_menu = 2;";
                    NpgsqlDataReader reader1 = command1.ExecuteReader();

                    while (reader1.Read())
                    {
                        label31.Text = Convert.ToString(reader1["count"]);
                    }
                }



                // Количество оливье
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command1 = new NpgsqlCommand();
                    command1.Connection = connection;
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = $"SELECT COUNT(sale_menu) \r\nFROM sale \r\nJOIN staff ON sale_staff = staff_id\r\nWHERE staff_name = '{SelectStaffComboBox.Text}' AND sale_menu = 3;";
                    NpgsqlDataReader reader1 = command1.ExecuteReader();

                    while (reader1.Read())
                    {
                        label30.Text = Convert.ToString(reader1["count"]);
                    }
                }


                // Количество блинов с красной икрой
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command1 = new NpgsqlCommand();
                    command1.Connection = connection;
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = $"SELECT COUNT(sale_menu) \r\nFROM sale \r\nJOIN staff ON sale_staff = staff_id\r\nWHERE staff_name = '{SelectStaffComboBox.Text}' AND sale_menu = 4;";
                    NpgsqlDataReader reader1 = command1.ExecuteReader();

                    while (reader1.Read())
                    {
                        label29.Text = Convert.ToString(reader1["count"]);
                    }
                }


                // Количество шашлыков со свининой
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command1 = new NpgsqlCommand();
                    command1.Connection = connection;
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = $"SELECT COUNT(sale_menu) \r\nFROM sale \r\nJOIN staff ON sale_staff = staff_id\r\nWHERE staff_name = '{SelectStaffComboBox.Text}' AND sale_menu = 5;";
                    NpgsqlDataReader reader1 = command1.ExecuteReader();

                    while (reader1.Read())
                    {
                        label28.Text = Convert.ToString(reader1["count"]);
                    }
                }


                // Количество салатов цезарь
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command1 = new NpgsqlCommand();
                    command1.Connection = connection;
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = $"SELECT COUNT(sale_menu) \r\nFROM sale \r\nJOIN staff ON sale_staff = staff_id\r\nWHERE staff_name = '{SelectStaffComboBox.Text}' AND sale_menu = 6;";
                    NpgsqlDataReader reader1 = command1.ExecuteReader();

                    while (reader1.Read())
                    {
                        label27.Text = Convert.ToString(reader1["count"]);
                    }
                }


                // Количество пирогов с вишней
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command1 = new NpgsqlCommand();
                    command1.Connection = connection;
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = $"SELECT COUNT(sale_menu) \r\nFROM sale \r\nJOIN staff ON sale_staff = staff_id\r\nWHERE staff_name = '{SelectStaffComboBox.Text}' AND sale_menu = 7;";
                    NpgsqlDataReader reader1 = command1.ExecuteReader();

                    while (reader1.Read())
                    {
                        label26.Text = Convert.ToString(reader1["count"]);
                    }
                }


                // Количество котлет по-киевски
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command1 = new NpgsqlCommand();
                    command1.Connection = connection;
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = $"SELECT COUNT(sale_menu) \r\nFROM sale \r\nJOIN staff ON sale_staff = staff_id\r\nWHERE staff_name = '{SelectStaffComboBox.Text}' AND sale_menu = 8;";
                    NpgsqlDataReader reader1 = command1.ExecuteReader();

                    while (reader1.Read())
                    {
                        label25.Text = Convert.ToString(reader1["count"]);
                    }
                }


                // Количество окрошек
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command1 = new NpgsqlCommand();
                    command1.Connection = connection;
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = $"SELECT COUNT(sale_menu) \r\nFROM sale \r\nJOIN staff ON sale_staff = staff_id\r\nWHERE staff_name = '{SelectStaffComboBox.Text}' AND sale_menu = 9;";
                    NpgsqlDataReader reader1 = command1.ExecuteReader();

                    while (reader1.Read())
                    {
                        label34.Text = Convert.ToString(reader1["count"]);
                    }
                }


                // Количество мант
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command1 = new NpgsqlCommand();
                    command1.Connection = connection;
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = $"SELECT COUNT(sale_menu) \r\nFROM sale \r\nJOIN staff ON sale_staff = staff_id\r\nWHERE staff_name = '{SelectStaffComboBox.Text}' AND sale_menu = 10;";
                    NpgsqlDataReader reader1 = command1.ExecuteReader();

                    while (reader1.Read())
                    {
                        label33.Text = Convert.ToString(reader1["count"]);
                    }
                }

                // Количество лимонада
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command1 = new NpgsqlCommand();
                    command1.Connection = connection;
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = $"SELECT COUNT(sale_menu) \r\nFROM sale \r\nJOIN staff ON sale_staff = staff_id\r\nWHERE staff_name = '{SelectStaffComboBox.Text}' AND sale_menu = 11;";
                    NpgsqlDataReader reader1 = command1.ExecuteReader();

                    while (reader1.Read())
                    {
                        label32.Text = Convert.ToString(reader1["count"]);
                    }
                }


                // Количество воды
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();


                    NpgsqlCommand command1 = new NpgsqlCommand();
                    command1.Connection = connection;
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = $"SELECT COUNT(sale_menu) \r\nFROM sale \r\nJOIN staff ON sale_staff = staff_id\r\nWHERE staff_name = '{SelectStaffComboBox.Text}' AND sale_menu = 12;";
                    NpgsqlDataReader reader1 = command1.ExecuteReader();

                    while (reader1.Read())
                    {
                        label44.Text = Convert.ToString(reader1["count"]);
                    }
                }
            }
        }
    }
}
