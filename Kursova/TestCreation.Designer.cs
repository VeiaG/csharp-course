namespace Kursova
{
    partial class TestCreation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestCreation));
            this.panel_header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.Panel();
            this.XIcon = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(30, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "Додати запитання";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(680, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Location = new System.Drawing.Point(30, 65);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(746, 310);
            this.panel.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(570, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 51);
            this.button2.TabIndex = 8;
            this.button2.Text = "Зберегти тест";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Назва";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(397, 398);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 28);
            this.button3.TabIndex = 10;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TestCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(253)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "TestCreation";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
    }
}

