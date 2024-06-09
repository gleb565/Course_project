using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Input;

namespace Курсовой_проект
{
    public partial class Staff_LK : Form
    {
        public Staff_LK(int StaffID)
        {
            InitializeComponent();
            LoadData(StaffID);

            OrderForm dialog = new OrderForm(StaffID);
        }

        private void LoadData(int StaffID)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection($"Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
            {
                connection.Open();

                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = $"SELECT * FROM staff WHERE staff_id = @staffId;";
                command.Parameters.AddWithValue("@staffId", StaffID);
                NpgsqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    label1.Text = reader["staff_name"].ToString();
                    label2.Text = reader["staff_surname"].ToString();
                    label3.Text = reader["staff_otchestvo"].ToString();
                    label5.Text = reader["staff_birth_date"].ToString();
                    label7.Text = reader["staff_phone_number"].ToString();
                    label9.Text = reader["staff_email"].ToString();
                }
                reader.Close();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
