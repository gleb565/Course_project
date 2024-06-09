using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Курсовой_проект
{
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection($"Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();

                    NpgsqlCommand command = new NpgsqlCommand();
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = $"INSERT INTO staff (staff_name, staff_surname, staff_otchestvo, staff_birth_date, staff_phone_number, staff_email, staff_login, staff_password)\r\nVALUES (@staff_name, @staff_surname, @staff_otchestvo, @staff_birth_date, @staff_phone_number, @staff_email, @staff_login, @staff_password);";

                    command.Parameters.AddWithValue("@staff_name", NameTextBox.Text);
                    command.Parameters.AddWithValue("@staff_surname", SurnameTextBox.Text);
                    command.Parameters.AddWithValue("@staff_otchestvo", OtchestvoTextBox.Text);
                    command.Parameters.AddWithValue("@staff_birth_date", Convert.ToDateTime(Date.Text));
                    command.Parameters.AddWithValue("@staff_phone_number", PhoneNumberTextBox.Text);
                    command.Parameters.AddWithValue("@staff_email", EmailTextBox.Text);
                    command.Parameters.AddWithValue("@staff_login", LoginTextBox.Text);
                    command.Parameters.AddWithValue("@staff_password", PasswordTextBox.Text);

                    command.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Ошибка при работе с базой данных: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
