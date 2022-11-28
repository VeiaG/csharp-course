using ReadWriteBinaryFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Kursova
{
    public partial class TestGo : Form
    {
        /*ПАНЕЛЬ*/
        bool drag = false;
        Point start_point = new Point(0, 0);
        StructFile.Question sv = new StructFile.Question();
        /* Кінець панел і*/
        public TestGo()
        {
            InitializeComponent();
            p2.Location = new Point(p1.Location.X, p1.Location.Y-45);
            p3.Location = p1.Location;
            
            if(StructFile.curTest == 0)
            {
                StructFile.Answers[StructFile.goS].Mark = 0;
            }
            RLoad(StructFile.curTest);
            label2.Text = StructFile.qq.Name;
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
        private void RLoad(int index)
        {
           
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
            Lquestion.Text = sv.qx;
            if (sv.Image)
            {
                Lquestion.Size = new Size(746, 80);
                pictureBox1.LoadAsync(sv.imgurl);
                
            }
            switch (sv.type)
            {
                case 0:
                    p1_t1.Text = sv.q1;
                    p1_t2.Text = sv.q2;
                    p1_t3.Text = sv.q3;
                    p1_t4.Text = sv.q4;
                    break;
                case 1:
                    ArrayList l = new ArrayList();
                    p2_t1.Text = sv.q1;
                    p2_t2.Text = sv.q2;
                    p2_t3.Text = sv.q3;
                    p2_t4.Text = sv.q4;
                    
                    l.Add(sv.r1);
                    l.Add(sv.r2);
                    l.Add(sv.r3);
                    l.Add(sv.r4);
                    RandomOrder(l, p2_r1);
                    RandomOrder(l, p2_r2);
                    RandomOrder(l, p2_r3);
                    RandomOrder(l, p2_r4);
                    
                    break;
                case 2:
                    p3_t1.Text = sv.q1;
                    p3_t2.Text = sv.q2;
                    p3_t3.Text = sv.q3;
                    p3_t4.Text = sv.q4;

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
        public void RandomOrder(ArrayList arrList, ComboBox box)
        {
            Random r = new Random();
            for (int cnt = 0; cnt < arrList.Count; cnt++)
            {
                object tmp = arrList[cnt];
                int idx = r.Next(arrList.Count - cnt) + cnt;
                arrList[cnt] = arrList[idx];
                arrList[idx] = tmp;
            }

            box.Items.Clear();
            box.Items.Add(arrList[0]);
            box.Items.Add(arrList[1]);
            box.Items.Add(arrList[2]);
            box.Items.Add(arrList[3]);


        }
        private void X_MouseLeave(object sender, EventArgs e)
        {
            X.BackColor = Color.FromArgb(104, 185, 132);
        }

        private void X_MouseEnter(object sender, EventArgs e)
        {
            X.BackColor = Color.FromArgb(254, 208, 73);
        }

        private void p1_t1_Click(object sender, EventArgs e)
        {
            Answer(1);
        }

        private void p1_t2_Click(object sender, EventArgs e)
        {
            Answer(2);
        }

        private void p1_t3_Click(object sender, EventArgs e)
        {
            Answer(3);
        }

        private void p1_t4_Click(object sender, EventArgs e)
        {
            Answer(4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (p3_t1.Checked == stb(sv.r1) && p3_t2.Checked == stb(sv.r2) && p3_t3.Checked == stb(sv.r3) && p3_t4.Checked == stb(sv.r4))
            {
                StructFile.Answers[StructFile.goS].Mark++;
            }
            TestEnd();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(p2_r1.Text == sv.r1 && p2_r2.Text == sv.r2 && p2_r3.Text == sv.r3 && p2_r4.Text == sv.r4)
            {
                StructFile.Answers[StructFile.goS].Mark++;
            }
            TestEnd();
        }
        private void Answer(int a)
        {
            switch(a){
                case 1:
                    if(sv.r1 == "1")
                    {
                        StructFile.Answers[StructFile.goS].Mark++;
                    }
                    break;
                case 2:
                    if (sv.r2 == "1")
                    {
                        StructFile.Answers[StructFile.goS].Mark++;
                    }
                    break;
                case 3:
                    if (sv.r3 == "1")
                    {
                        StructFile.Answers[StructFile.goS].Mark++;
                    }
                    break;
                case 4:
                    if (sv.r4 == "1")
                    {
                        StructFile.Answers[StructFile.goS].Mark++;
                    }
                    break;
            }
            TestEnd();
           
        }
        private void TestEnd()
        {
            if (StructFile.curTest < StructFile.qq.Size - 1)
            {
                StructFile.curTest++;
                Close();
                TestGo t = new TestGo();
                t.Show();
                t.Location = this.Location;
            }
            else
            {
                //кінець тесту
                Close();
                EndTest t = new EndTest();
                t.Show();
                t.Location = this.Location;
            }
        }
        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
                pictureBox1.Show();
        }
        /* Кінець панел і*/
    }
}
