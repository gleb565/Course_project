using FontAwesome.Sharp;
using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Курсовой_проект
{
    public partial class Staff : Form
    {

        public Staff()
        {
            InitializeComponent();
            LoadStaffData();

        }

        private void LoadStaffData()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection($"Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
            {
                connection.Open();

                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = $"SELECT * FROM staff;";
                NpgsqlDataReader reader = command.ExecuteReader();

                int buttonLeft = 100;
                int buttonStep = 150; // Шаг для позиционирования кнопок

                while (reader.Read())
                {
                    IconButton button = new IconButton();
                    button.Left = buttonLeft;
                    button.Text = reader["staff_name"].ToString();
                    button.Tag = Convert.ToInt32(reader["staff_id"].ToString());
                    button.Click += Button_Click;

                    
                    button.Font = new Font("Arial", 12, FontStyle.Bold);
                    button.IconChar = IconChar.User;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.ImageAlign = ContentAlignment.MiddleLeft;
                    button.TextAlign = ContentAlignment.MiddleRight;
                    button.IconSize = 30;
                    button.Width = 150;
                    button.Height = 60;
                   

                    // Добавить иконку на панель
                    panel2.Controls.Add(button);

                    buttonLeft += buttonStep; // Увеличиваем позицию кнопки на шаг
                }

                reader.Close();
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            int StaffID = Convert.ToInt32(((IconButton)sender).Tag);
            this.Hide();
            Staff_LK dialog = new Staff_LK(StaffID);

            dialog.ShowDialog();
            Show();

            
        }

        private void AddPersonalButton_Click_1(object sender, EventArgs e)
        {
            AddStaff dialog = new AddStaff();
            dialog.ShowDialog();
        }

        
    }
}