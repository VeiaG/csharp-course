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
    public partial class TeacherCabinet : Form
    {
        /*ПАНЕЛЬ*/
        bool drag = false;
        Point start_point = new Point(0, 0);
        public TeacherCabinet()
        {

            
            InitializeComponent();
            string data = File.ReadAllText("test.json");
            StructFile.T = JsonConvert.DeserializeObject<StructFile.gt>(data);
            if (StructFile.TisSelected)
            {
                StructFile.TisSelected = false;
            }
            StructFile.Tnew = true;
            //----------------
            for (int i = 0; i < StructFile.T.Size; i++)
            {
                Panel p = new Panel();
                p.BackColor = Color.White;
                p.Size = new Size(700, 80);
                p.Location = new Point(0, i * 96);
                // -------------
                Label name = new Label();
                name.Text = StructFile.T.allT[i].Name;
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
            StructFile.Test[] temp;
            temp = Array.Empty<StructFile.Test>();
            for (int i=0;i < StructFile.T.Size; i++)
            {
                if (i != int.Parse(btn.Name.Remove(0, 1))-1)
                {
                    var templist = temp.ToList();
                    templist.Add(StructFile.T.allT[i]);
                    temp = templist.ToArray();
                }
            }
            StructFile.T.Size -= 1;
            StructFile.T.allT = temp;
            string output = JsonConvert.SerializeObject(StructFile.T);
            File.WriteAllText("test.json", output);
            Close();
            TeacherCabinet t = new TeacherCabinet();
            t.Show();
            t.Location = this.Location;
            
        }
        void r_button_click(object sender, EventArgs e)
        {
            //редагування нажате
            Button btn = sender as Button;
            StructFile.Tselected = int.Parse(btn.Name.Remove(0, 1)) - 1;
            StructFile.TisSelected = true;
            StructFile.Tnew = true;
            StructFile.qq = StructFile.T.allT[StructFile.Tselected];
            
            Close();
            TestCreation t = new TestCreation();
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
            StructFile.qq.Name = "";
            StructFile.qq.Size = 0;
            StructFile.qq.questions = Array.Empty<StructFile.Question>();
            Close();
            TestCreation t = new TestCreation();
            t.Show();
            t.Location = this.Location;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            Login t = new Login();
            t.Show();
            t.Location = this.Location;
        }
        /* Кінець панел і*/
    }
}
