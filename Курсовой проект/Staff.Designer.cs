using FontAwesome.Sharp;

namespace Курсовой_проект
{
    partial class Staff
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddPersonalButton = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(179)))), ((int)(((byte)(163)))));
            this.panel1.Controls.Add(this.AddPersonalButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 55);
            this.panel1.TabIndex = 0;
            // 
            // AddPersonalButton
            // 
            this.AddPersonalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPersonalButton.FlatAppearance.BorderSize = 0;
            this.AddPersonalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPersonalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPersonalButton.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.AddPersonalButton.IconColor = System.Drawing.Color.Black;
            this.AddPersonalButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddPersonalButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddPersonalButton.Location = new System.Drawing.Point(667, 3);
            this.AddPersonalButton.Name = "AddPersonalButton";
            this.AddPersonalButton.Size = new System.Drawing.Size(121, 40);
            this.AddPersonalButton.TabIndex = 0;
            this.AddPersonalButton.Text = "Добавить";
            this.AddPersonalButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddPersonalButton.UseVisualStyleBackColor = true;
            this.AddPersonalButton.Click += new System.EventHandler(this.AddPersonalButton_Click_1);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(179)))), ((int)(((byte)(163)))));
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 403);
            this.panel2.TabIndex = 1;
            //
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staff";
            this.Text = "Personal";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton AddPersonalButton;
        private System.Windows.Forms.Panel panel2;
    }
}