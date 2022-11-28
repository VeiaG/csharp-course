using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ReadWriteBinaryFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace Kursova
{
    public partial class NewQ : Form
    {
        
        /*ПАНЕЛЬ*/
        bool drag = false;
        Point start_point = new Point(0, 0);
        /* Кінець панел і*/
        public NewQ()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            p2.Location = p1.Location;
            p3.Location = p1.Location;
            if (StructFile.QisSelected)
            {
                RLoad(StructFile.Qselected);
                button1.Text = "Прийняти зміни";
                button2.Visible = true;
            }
        }
        /* ПАНЕЛЬ */
        private void RLoad(int index)
        {
            
            StructFile.Question sv = new StructFile.Question();
            /*читання */
            
            sv = StructFile.qq.questions[index];

            /* приколюхи далі */

            switch (sv.type)
            {
                case 0:
                    p1.Show();
                    p2.Hide();
                    p3.Hide();
                    break;
                case 1:
                    p1.Hide();
                    p2.Show();
                    p3.Hide();
                    break;
                case 2:
                    p1.Hide();
                    p2.Hide();
                    p3.Show();
                    break;
            }
            textBox1.Text = sv.qx;
            comboBox1.SelectedIndex = sv.type;
            checkBox1.Checked = sv.Image;
            urlT.Text = sv.imgurl;
            switch (sv.type)
            {
                case 0:
                    p1_t1.Text = sv.q1;
                    p1_t2.Text = sv.q2;
                    p1_t3.Text = sv.q3;
                    p1_t4.Text = sv.q4;

                    p1_r1.Checked = stb(sv.r1);
                    p1_r2.Checked = stb(sv.r2);
                    p1_r3.Checked = stb(sv.r3);
                    p1_r4.Checked = stb(sv.r4);
                    break;
                case 1:
                    p2_t1.Text = sv.q1;
                    p2_t2.Text = sv.q2;
                    p2_t3.Text = sv.q3;
                    p2_t4.Text = sv.q4;

                    p2_r1.Text = sv.r1;
                    p2_r2.Text = sv.r2;
                    p2_r3.Text = sv.r3;
                    p2_r4.Text = sv.r4;
                    break;
                case 2:
                    p3_t1.Text = sv.q1;
                    p3_t2.Text = sv.q2;
                    p3_t3.Text = sv.q3;
                    p3_t4.Text = sv.q4;

                    p3_r1.Checked = stb(sv.r1);
                    p3_r2.Checked = stb(sv.r2);
                    p3_r3.Checked = stb(sv.r3);
                    p3_r4.Checked = stb(sv.r4);
                    break;
            }

        }
        private bool stb(string ss)
        {
            if (ss == "0")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void panel_header_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true; //drag is your variable flag.
            start_point = new Point(e.X, e.Y);
        }

        private void panel_header_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
        private void panel_header_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void X_MouseLeave(object sender, EventArgs e)
        {
            X.BackColor = Color.FromArgb(104, 185, 132);
        }

        private void X_MouseEnter(object sender, EventArgs e)
        {
            X.BackColor = Color.FromArgb(254, 208, 73);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            if (checkBox1.Checked && urlT.Text != "")
            {
                pictureBox1.LoadAsync(urlT.Text);
            }
        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            pictureBox1.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    p1.Show();
                    p2.Hide();
                    p3.Hide();
                    break;
                case 1:
                    p1.Hide();
                    p2.Show();
                    p3.Hide();
                    break;
                case 2:
                    p1.Hide();
                    p2.Hide();
                    p3.Show();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            StructFile.Question sv = new StructFile.Question();
            try
            {
                sv.qx = textBox1.Text;
                sv.type = comboBox1.SelectedIndex;
                sv.Image = checkBox1.Checked;
                sv.imgurl = urlT.Text;
                switch (sv.type)
                {
                    case 0:
                        sv.q1 = p1_t1.Text;
                        sv.q2 = p1_t2.Text;
                        sv.q3 = p1_t3.Text;
                        sv.q4 = p1_t4.Text;
                        /* */
                        sv.r1 = p1_r1.Checked ? "1" : "0";
                        sv.r2 = p1_r2.Checked ? "1" : "0";
                        sv.r3 = p1_r3.Checked ? "1" : "0";
                        sv.r4 = p1_r4.Checked ? "1" : "0";
                        break;
                    case 1:
                        sv.q1 = p2_t1.Text;
                        sv.q2 = p2_t2.Text;
                        sv.q3 = p2_t3.Text;
                        sv.q4 = p2_t4.Text;
                        /* */
                        sv.r1 = p2_r1.Text;
                        sv.r2 = p2_r2.Text;
                        sv.r3 = p2_r3.Text;
                        sv.r4 = p2_r4.Text;
                        break;
                    case 2:
                        sv.q1 = p3_t1.Text;
                        sv.q2 = p3_t2.Text;
                        sv.q3 = p3_t3.Text;
                        sv.q4 = p3_t4.Text;
                        /* */
                        sv.r1 = p3_r1.Checked ? "1" : "0";
                        sv.r2 = p3_r2.Checked ? "1" : "0";
                        sv.r3 = p3_r3.Checked ? "1" : "0";
                        sv.r4 = p3_r4.Checked ? "1" : "0";
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Неправильний тип данних\r\n" + ex.Message);
                return;
            }
            if (StructFile.QisSelected)
            {
                StructFile.qq.questions[StructFile.Qselected] = sv;
            }
            else
            {
                StructFile.qq.Size++;
                Array.Resize(ref StructFile.qq.questions, StructFile.qq.Size);
                
                StructFile.qq.questions[StructFile.qq.Size - 1] = sv;
            }
            try
            {
                
                Close();
                TestCreation t = new TestCreation();
                t.Show();
                t.Location = this.Location;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            TestCreation t = new TestCreation();
            t.Show();
            t.Location = this.Location;
        }
    }
}
