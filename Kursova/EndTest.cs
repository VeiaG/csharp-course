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
    public partial class EndTest : Form
    {
        /*ПАНЕЛЬ*/
        bool drag = false;
        Point start_point = new Point(0, 0);
        /* Кінець панел і*/
        public EndTest()
        {
            InitializeComponent();
            label2.Text = StructFile.qq.Name;
            label3.Text = StructFile.Answers[StructFile.goS].Mark + "/" + StructFile.Answers[StructFile.goS].AllM;
            label3.Location = pictureBox1.PointToClient(label3.Parent.PointToScreen(label3.Location));
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
            double tw = Math.Round(((double)StructFile.Answers[StructFile.goS].Mark / (double)StructFile.Answers[StructFile.goS].AllM) * 12);
            double msize = ((double)StructFile.Answers[StructFile.goS].Mark / (double)StructFile.Answers[StructFile.goS].AllM) * 558;
            label4.Text = "Оцінка по 12-бальній шкалі : " + tw + "/12 б.";
            Panel mfront = new Panel();
            mfront.BackColor = Color.FromArgb(254, 208, 73);
            mfront.Size = new Size((int)msize, 20);
            mback.Controls.Add(mfront);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            StudentCabinet t = new StudentCabinet();
            t.Show();
            t.Location = this.Location;
        }
        /* Кінець панел і*/
    }
}
