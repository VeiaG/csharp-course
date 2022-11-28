namespace Kursova
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel_header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.Panel();
            this.XIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_header.SuspendLayout();
            this.X.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.XIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Kursova.Properties.Resources._1;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(439, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(298, 339);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kursova.Properties.Resources._2;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(49, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 339);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(253)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Login";
            this.Text = "Тестування";
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.X.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.XIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Panel X;
        private System.Windows.Forms.PictureBox XIcon;
        private System.Windows.Forms.Label label1;
    }
}

