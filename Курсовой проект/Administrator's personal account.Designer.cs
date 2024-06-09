using System.Windows.Forms;

namespace Курсовой_проект
{
    partial class Administrator_s_personal_account
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinimazeButton = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.CloseButton = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Statistic = new FontAwesome.Sharp.IconButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.ExitButton = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Personal = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2BorderlessForm2 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2BorderlessForm3 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.MinimazeButton);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 26);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // MinimazeButton
            // 
            this.MinimazeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimazeButton.BackColor = System.Drawing.Color.Gray;
            this.MinimazeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimazeButton.FlatAppearance.BorderSize = 0;
            this.MinimazeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimazeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.MinimazeButton.IconColor = System.Drawing.Color.Black;
            this.MinimazeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinimazeButton.IconSize = 30;
            this.MinimazeButton.Location = new System.Drawing.Point(1012, 1);
            this.MinimazeButton.Name = "MinimazeButton";
            this.MinimazeButton.Size = new System.Drawing.Size(36, 27);
            this.MinimazeButton.TabIndex = 1;
            this.MinimazeButton.UseVisualStyleBackColor = false;
            this.MinimazeButton.Click += new System.EventHandler(this.MinimazeButton_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.BackColor = System.Drawing.Color.Gray;
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.Location = new System.Drawing.Point(1042, 3);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(34, 23);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.Gray;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.CloseButton.IconColor = System.Drawing.Color.Black;
            this.CloseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseButton.IconSize = 30;
            this.CloseButton.Location = new System.Drawing.Point(1071, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(34, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.Statistic);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 654);
            this.panel2.TabIndex = 1;
            // 
            // Statistic
            // 
            this.Statistic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Statistic.FlatAppearance.BorderSize = 0;
            this.Statistic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Statistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Statistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Statistic.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.Statistic.IconColor = System.Drawing.Color.Black;
            this.Statistic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Statistic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Statistic.Location = new System.Drawing.Point(3, 112);
            this.Statistic.Name = "Statistic";
            this.Statistic.Size = new System.Drawing.Size(217, 80);
            this.Statistic.TabIndex = 3;
            this.Statistic.Text = "Статистика";
            this.Statistic.UseVisualStyleBackColor = true;
            this.Statistic.Click += new System.EventHandler(this.Statistic_Click);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel7.Controls.Add(this.ExitButton);
            this.panel7.Location = new System.Drawing.Point(3, 563);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(214, 91);
            this.panel7.TabIndex = 4;
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.ExitButton.IconColor = System.Drawing.Color.Black;
            this.ExitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location = new System.Drawing.Point(11, 19);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(211, 60);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Personal);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(225, 108);
            this.panel5.TabIndex = 1;
            // 
            // Personal
            // 
            this.Personal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Personal.FlatAppearance.BorderSize = 0;
            this.Personal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Personal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Personal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Personal.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.Personal.IconColor = System.Drawing.Color.Black;
            this.Personal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Personal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Personal.Location = new System.Drawing.Point(3, 6);
            this.Personal.Name = "Personal";
            this.Personal.Size = new System.Drawing.Size(214, 89);
            this.Personal.TabIndex = 1;
            this.Personal.Text = "Персонал";
            this.Personal.UseVisualStyleBackColor = true;
            this.Personal.Click += new System.EventHandler(this.Personal_Click);
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(5, 109);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(223, 100);
            this.panel6.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(220, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(885, 654);
            this.panel3.TabIndex = 2;
            // 
            // guna2BorderlessForm2
            // 
            this.guna2BorderlessForm2.ContainerControl = this;
            this.guna2BorderlessForm2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm2.TransparentWhileDrag = true;
            // 
            // guna2BorderlessForm3
            // 
            this.guna2BorderlessForm3.ContainerControl = this;
            this.guna2BorderlessForm3.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm3.TransparentWhileDrag = true;
            // 
            // Administrator_s_personal_account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(179)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(1105, 680);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administrator_s_personal_account";
            this.Text = "Administrator_s_personal_account";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        private Form activeForm = null;

        private void openForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(childForm);
            panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton CloseButton;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton MinimazeButton;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm2;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton Personal;
        private FontAwesome.Sharp.IconButton Statistic;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private FontAwesome.Sharp.IconButton ExitButton;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm3;
    }
}