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
using System.IO;


namespace Kursova
{
    public partial class TestCreation : Form
    {
        /*ПАНЕЛЬ*/
        bool drag = false;
        Point start_point = new Point(0, 0);
        public TestCreation()
        {
            InitializeComponent();
            textBox1.Text = StructFile.qq.Name;
            if (StructFile.QisSelected)
            {
                StructFile.QisSelected = false;
            }
            if (StructFile.TisSelected)
            {
                
                
                button3.Visible = true;
            }
            else if(StructFile.Tnew)
            {
                StructFile.Tnew = false;
            }
            //----------------
            for (int i = 0; i <= StructFile.qq.Size-1; i++)
            {
                Panel p = new Panel();
                p.BackColor = Color.White;
                p.Size = new Size(700, 80);
                p.Location = new Point(0, i * 96);
                // -------------
                Label name = new Label();
                name.Text = StructFile.qq.questions[i].qx;
                name.Font = new Font("Arial", 12, FontStyle.Bold);
                name.AutoSize = false;
                name.Size = new Size(560, 80);
                name.TextAlign = ContentAlignment.MiddleLeft;
                Button del = new Button();
                Button red = new Button();
                // -------------
                del.Size = new Size(120, 30);
                del.Location = new Point(570, 45);
                del.Text = "Видалити";

                red.Size = new Size(120, 30);
                red.Location = new Point(570, 10);
                red.Text = "Редагувати";
                // -------------
                p.Controls.Add(name);
                p.Controls.Add(del);
                p.Controls.Add(red);
                del.Name = "d" + (i + 1);
                red.Name = "r" + (i + 1);
                del.Click += new EventHandler(this.d_button_click);
                red.Click += new EventHandler(this.r_button_click);
                panel.Controls.Add(p);
            }
        }

        void d_button_click(object sender , EventArgs e)
        {
            //видалення нажате
            Button btn = sender as Button;
            StructFile.Test temp = new StructFile.Test();
            temp.questions = Array.Empty<StructFile.Question>();
            for (int i=0;i < StructFile.qq.Size; i++)
            {
                if (i != int.Parse(btn.Name.Remove(0, 1))-1)
                {
                    var templist = temp.questions.ToList();
                    templist.Add(StructFile.qq.questions[i]);
                    temp.questions = templist.ToArray();
                }
            }
            temp.Size = StructFile.qq.Size-1;
            temp.Name = StructFile.qq.Name;
            StructFile.qq = temp;
            //reload
            
            Close();
            TestCreation t = new TestCreation();
            t.Show();
            t.Location = this.Location;

        }
        void r_button_click(object sender, EventArgs e)
        {
            //редагування нажате
            Button btn = sender as Button;
            StructFile.Qselected = int.Parse(btn.Name.Remove(0, 1)) - 1;
            StructFile.QisSelected = true;
            Close();
            NewQ t = new NewQ();
            t.Show();
            t.Location = this.Location;
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
            NewQ t = new NewQ();
            t.Show();
            t.Location = this.Location;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (StructFile.TisSelected)
            {
                StructFile.T.allT[StructFile.Tselected] = StructFile.qq;
                string output = JsonConvert.SerializeObject(StructFile.T);
                File.WriteAllText("test.json", output);
            }
            else
            {
                StructFile.T.Size++;
                Array.Resize(ref StructFile.T.allT, StructFile.T.Size);

                StructFile.T.allT[StructFile.T.Size - 1] = StructFile.qq;
                string output = JsonConvert.SerializeObject(StructFile.T);
                File.WriteAllText("test.json", output);
            }
            Close();
            TeacherCabinet t = new TeacherCabinet();
            t.Show();
            t.Location = this.Location;
            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            StructFile.qq.Name = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            TeacherCabinet t = new TeacherCabinet();
            t.Show();
            t.Location = this.Location;
        }
        /* Кінець панел і*/
    }
}
