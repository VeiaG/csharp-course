namespace Kursova
{
    partial class EndTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndTest));
            this.panel_header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.Panel();
            this.XIcon = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mback = new System.Windows.Forms.Panel();
            this.panel_header.SuspendLayout();
            this.X.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.XIcon)).BeginInit();
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(253)))), ((int)(((byte)(225)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(35, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "До тестів";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(28, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(745, 64);
            this.label2.TabIndex = 4;
            this.label2.Text = "НАЗВА ТЕСТУ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(641, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 119);
            this.label3.TabIndex = 5;
            this.label3.Text = "15/20";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kursova.Properties.Resources.Ellipse_1;
            this.pictureBox1.Location = new System.Drawing.Point(629, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(28, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(565, 65);
            this.label4.TabIndex = 7;
            this.label4.Text = "Оцінка по 12-бальній шкалі :  12/12 б.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mback
            // 
            this.mback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(185)))), ((int)(((byte)(132)))));
            this.mback.Location = new System.Drawing.Point(35, 172);
            this.mback.Name = "mback";
            this.mback.Size = new System.Drawing.Size(558, 20);
            this.mback.TabIndex = 8;
            // 
            // EndTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(253)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(800, 284);
            this.Controls.Add(this.mback);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "EndTest";
            this.Text = "Тестування";
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.X.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.XIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Panel X;
        private System.Windows.Forms.PictureBox XIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel mback;
    }
}

