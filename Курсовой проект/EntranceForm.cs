using Guna.UI2.WinForms;
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
    public partial class EntranceForm : Form
    {
        public EntranceForm()
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
                    EntranceComboBox.Items.Add(reader["staff_name"]);

                }

                EntranceComboBox.Items.Add("Администратор");
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
            {
                connection.Open();

                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = $"SELECT * FROM administrator;";
                NpgsqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (EntranceComboBox.Text == "Администратор" && reader.GetString(reader.GetOrdinal("administrator_login")) == LoginTextBox.Text && reader.GetString(reader.GetOrdinal("administrator_password")) == PasswordTextBox.Text)
                        {
                            this.Hide();
                            Administrator_s_personal_account dialog = new Administrator_s_personal_account();
                            dialog.ShowDialog();
                            Show();
                            return;
                        }
                    }
                }

                reader.Close();

                using (NpgsqlConnection connection1 = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection1.Open();

                    NpgsqlCommand command1 = new NpgsqlCommand();
                    command1.Connection = connection1;
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = $"SELECT * FROM staff;";
                    NpgsqlDataReader reader1 = command1.ExecuteReader();

                    if (reader1.HasRows)
                    {
                        while (reader1.Read())
                        {
                            if (reader1.GetString(reader1.GetOrdinal("staff_name")) == EntranceComboBox.Text & reader1.GetString(reader1.GetOrdinal("staff_login")) == LoginTextBox.Text && reader1.GetString(reader1.GetOrdinal("staff_password")) == PasswordTextBox.Text)
                            {
                                this.Hide();
                                StaffPersonalAccount dialog = new StaffPersonalAccount(Convert.ToInt32(reader1["staff_id"]));
                                dialog.ShowDialog();
                                Show();
                                return;
                            }
                        }
                    }

                    reader1.Close();

                    MessageBox.Show("Вы ввели неправильный логин или пароль!");
                }
            }
        }

        
    }
}
