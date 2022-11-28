using Newtonsoft.Json;
using ReadWriteBinaryFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kursova
{
    public partial class TeacherLogin : Form
    {
        /*ПАНЕЛЬ*/
        bool drag = false;
        Point start_point = new Point(0, 0);
        /* Кінець панел і*/
        public TeacherLogin()
        {
            InitializeComponent();
            
        }


        /* ПАНЕЛЬ */
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
        /* Кінець панел і*/
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            Login t = new Login();
            t.Show();
            t.Location = this.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "12345678")
            {
                Close();
                TeacherCabinet t = new TeacherCabinet();
                t.Show();
                t.Location = this.Location;
            }
            else
            {
                label3.Text = "НЕВІРНИЙ ПАРОЛЬ";
            }
        }
    }
}
