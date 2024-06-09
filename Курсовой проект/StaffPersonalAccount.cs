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
    public partial class StaffPersonalAccount : Form
    {

        public int Tagg { get; set; }
        public StaffPersonalAccount(int Tag)
        {
            InitializeComponent();
            Tagg = Tag;
        }

        // Для перетаскивания формы
        bool draggind = false;
        Point dragCursorPoint;
        Point dragFormPoint;


        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                this.WindowState |= FormWindowState.Maximized;
            }
        }

        private void MinimazeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EntranceForm dialog = new EntranceForm();

            dialog.ShowDialog();
            Show();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            draggind = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            draggind = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (draggind)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Personal_Click(object sender, EventArgs e)
        {
            openForm(new Staff_LK(Tagg));
        }

        private void Statistic_Click(object sender, EventArgs e)
        {
            openForm(new OrderForm(Tagg));
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            openForm(new StatisticStaffForm(Tagg));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
