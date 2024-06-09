using FontAwesome.Sharp;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Курсовой_проект
{
    public partial class OrderForm : Form
    {
        DataTable dataTable = new DataTable();
        
        public List<string> items = new List<string>();
        public int StaffId;

        public OrderForm(int staffID)
        {
            InitializeComponent();

            this.StaffId = staffID;

            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
            {
                connection.Open();

                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = $"SELECT * FROM menu;";
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    FoodComboBox.Items.Add(reader["menu_food_name"]);
                }
            }

            dataTable.Columns.Add("Позиция из меню");

        }

        private void AddFoodButton_Click(object sender, EventArgs e)
        {
            // Добавляем данные из ComboBox в DataTable
            dataTable.Rows.Add(FoodComboBox.Text);
            items.Add(Convert.ToString(FoodComboBox.Text));

            // Привязываем DataTable к DataGrid
            guna2DataGridView1.DataSource = dataTable;

            
            for(int i = 0; i < items.Count(); i++)
            {
                // Создаем новый label
                Label newLabel = new Label();
                newLabel.Text = items[i];
                newLabel.AutoSize = true;

                // Добавляем label на форму
                this.Controls.Add(newLabel);
            }
           


        }

        private void DeleteFood_Click(object sender, EventArgs e)
        {
            List<int> rowsToDelete = new List<int>();

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == FoodComboBox.Text)
                {
                    rowsToDelete.Add(row.Index);
                }
            }

            foreach (int rowIndex in rowsToDelete)
            {
                guna2DataGridView1.Rows.RemoveAt(rowIndex);
                items.RemoveAt(rowIndex); // Предполагая, что у вас есть список items, который нужно синхронизировать с удалением строк
            }
        }


        // Движение и остановка ProgressBar

        private Timer _timer;
        private bool order_Ready = false;
        private int currentProgress = 0;

        private void CreateOrder_Click(object sender, EventArgs e)
        {
            _timer = new Timer();
            _timer.Interval = 500; // 500 миллисекунд
            _timer.Enabled = true;
            _timer.Tick += timer_Tick;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
             guna2ProgressBar1.Value = currentProgress;
            if (currentProgress < guna2ProgressBar1.Maximum) // Проверяем, достигнуто ли максимальное значение TrackBar1
            {
                currentProgress++;
            }
            else
            {
                order_Ready = true; // Устанавливаем флаг order_Ready в true
                _timer.Stop(); // Останавливаем таймер
                MessageBox.Show("Заказ готов!"); // Показываем сообщение
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection($"Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
            {
                int labelTop = 100; // Start position for the first label
                int labelStep = 30; // Vertical spacing between labels

                for (int i = 0; i < items.Count(); i++)
                {
                    // Create a new label
                    Label newLabel = new Label();
                    newLabel.Text = items[i];
                    newLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    newLabel.AutoSize = true;
                    newLabel.Location = new Point(10, labelTop + (i * labelStep)); // Set the label's position

                    // Add the label to the form
                    this.tabPage3.Controls.Add(newLabel);
                }

                connection.Open();

                int labelTop2 = 100; // Start position for the first label
                int labelStep2 = 30; // Vertical spacing between labels
                int sum = 0;

                for (int i = 0; i < items.Count(); i++)
                {
                    NpgsqlCommand command = new NpgsqlCommand();
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = $"SELECT menu_food_price FROM menu WHERE menu_food_name = @menuFoodName;";
                    command.Parameters.AddWithValue("@menuFoodName", items[i]);
                    NpgsqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Create a new label
                        Label newLabel = new Label();
                        newLabel.Text = reader["menu_food_price"].ToString(); // Use typed access to the data
                        newLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        newLabel.AutoSize = true;
                        newLabel.Location = new Point(200, labelTop2 + (i * labelStep2)); // Set the label's position

                        sum += Convert.ToInt32(newLabel.Text);

                        // Add the label to the form
                        this.tabPage3.Controls.Add(newLabel);
                    }

                    reader.Close();
                }

                label4.Text = Convert.ToString(sum);
            }
        }

        private int MenuId(string items)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection($"Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
            {
                connection.Open();

                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = $"SELECT menu_id FROM menu\r\nWHERE menu_food_name = @items;";
                command.Parameters.AddWithValue("@items", items);

                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < items.Count();i++)
            {
                using (NpgsqlConnection connection = new NpgsqlConnection($"Server=localhost;Port=5432;Database=restorant;User Id=postgres;Password=5176565195"))
                {
                    connection.Open();

                    NpgsqlCommand command = new NpgsqlCommand();
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = $"INSERT INTO sale (sale_date, sale_menu, sale_staff) VALUES (@sale_date, @sale_menu, @sale_staff);";

                    command.Parameters.AddWithValue("@sale_date", DateTime.Now);
                    command.Parameters.AddWithValue("@sale_menu", Convert.ToInt32(MenuId(items[i])));
                    command.Parameters.AddWithValue("@sale_staff", StaffId);

                    command.ExecuteNonQuery();
                }
            }
            
        }

      
    }
}
