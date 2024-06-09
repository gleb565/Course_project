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
    public partial class StatisticStaffForm : Form
    {
        public StatisticStaffForm(int StaffID)
        {
            InitializeComponent();

            // Всего заказов за день
            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
            {
                connection.Open();

                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = $"SELECT COUNT(*) \r\nFROM (SELECT COUNT(*) \r\n\t  FROM sale\r\n\t  JOIN staff ON sale_staff = staff_id\r\n\t  WHERE DATE(sale_date) = CURRENT_DATE AND staff_id = '{StaffID}'\r\n\t  GROUP BY sale_date);";
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    label6.Text = Convert.ToString(reader["count"]);
                }
            }




            // Всего заказов за неделю
            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
            {
                connection.Open();

                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = $"SELECT COUNT(*) \r\nFROM (SELECT COUNT(*)\r\n\t  FROM sale\r\n\t  JOIN staff ON sale_staff = staff_id\r\n\t  WHERE DATE_PART('week', sale_date) = DATE_PART('week', CURRENT_DATE) AND staff_id = '{StaffID}'\r\n\t  GROUP BY sale_date);";
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    label7.Text = Convert.ToString(reader["count"]);
                }
            }




            // Всего заказов за месяц
            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
            {
                connection.Open();

                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = $"SELECT COUNT(*) \r\nFROM (SELECT COUNT(*)\r\n\t  FROM sale\r\n\t  JOIN staff ON sale_staff = staff_id\r\n\t  WHERE DATE_PART('month', sale_date) = DATE_PART('month', CURRENT_DATE) AND staff_id = '{StaffID}'\r\n\t  GROUP BY sale_date);";
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    label8.Text = Convert.ToString(reader["count"]);
                }
            }




            // Всего заказов
            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
            {
                connection.Open();

                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = $"SELECT COUNT(*) \r\nFROM (SELECT COUNT(*)\r\n\t  FROM sale\r\n\t  JOIN staff ON sale_staff = staff_id\r\n\t  WHERE staff_id = '{StaffID}'\r\n\t  GROUP BY sale_date);";
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    label9.Text = Convert.ToString(reader["count"]);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
