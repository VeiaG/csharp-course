namespace Kursova
{
    partial class TeacherLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherLogin));
            this.panel_header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.Panel();
            this.XIcon = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_header.SuspendLayout();
            this.X.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.XIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(185)))), ((int)(((byte)(132)))));
            this.panel_header.Controls.Add(this.label1);
            this.panel_header.Controls.Add(this.X);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel_header.Size = new System.Drawing.Size(800, 24);
            this.panel_header.TabIndex = 2;
            this.panel_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_header_MouseDown);
            this.panel_header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_header_MouseMove);
            this.panel_header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_header_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Тестування ";
            // 
            // X
            // 
            this.X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(185)))), ((int)(((byte)(132)))));
            this.X.Controls.Add(this.XIcon);
            this.X.Location = new System.Drawing.Point(776, 0);
            this.X.Name = "X";
            this.X.Padding = new System.Windows.Forms.Padding(2);
            this.X.Size = new System.Drawing.Size(24, 24);
            this.X.TabIndex = 3;
            this.X.Click += new System.EventHandler(this.X_Click);
            this.X.MouseEnter += new System.EventHandler(this.X_MouseEnter);
            this.X.MouseLeave += new System.EventHandler(this.X_MouseLeave);
            // 
            // XIcon
            // 
            this.XIcon.BackColor = System.Drawing.Color.Transparent;
            this.XIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XIcon.Enabled = false;
            this.XIcon.Image = global::Kursova.Properties.Resources.X_icon;
            this.XIcon.Location = new System.Drawing.Point(2, 2);
            this.XIcon.Margin = new System.Windows.Forms.Padding(0);
            this.XIcon.Name = "XIcon";
            this.XIcon.Size = new System.Drawing.Size(20, 20);
            this.XIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.XIcon.TabIndex = 4;
            this.XIcon.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(140, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(489, 73);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введіть пароль";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(138, 224);
            this.textBox1.MaxLength = 8;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(491, 31);
            this.textBox1.TabIndex = 4;
            this.textBox1.UseSystemPasswordChar = true;
            this.textBox1.WordWrap = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(138, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(491, 54);
            this.button1.TabIndex = 5;
            this.button1.Text = "Увійти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(317, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(138, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(491, 13);
            this.label3.TabIndex = 7;
            // 
            // TeacherLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(253)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "TeacherLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Тестування";
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.X.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.XIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Panel X;
        private System.Windows.Forms.PictureBox XIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
    }
}

