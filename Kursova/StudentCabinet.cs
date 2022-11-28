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
    public partial class StudentCabinet : Form
    {
        /*ПАНЕЛЬ*/
        bool drag = false;
        Point start_point = new Point(0, 0);
        public StudentCabinet()
        {

            
            InitializeComponent();
            string data = File.ReadAllText("test.json");
            StructFile.T = JsonConvert.DeserializeObject<StructFile.gt>(data);
            if (StructFile.TisSelected)
            {
                StructFile.TisSelected = false;
            }
            StructFile.Tnew = true;
            Array.Resize(ref StructFile.Answers, StructFile.T.Size);
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
                // -------------
                StructFile.Answers[i].AllM = StructFile.T.allT[i].Size;
                StructFile.Answers[i].selected = i;
                Label mark = new Label();
                mark.Text = StructFile.Answers[i].Mark +"/" +StructFile.Answers[i].AllM;
                mark.Font = new Font("Arial", 12, FontStyle.Bold);
                mark.AutoSize = false;
                mark.Size = new Size(60, 80);
                mark.Location = new Point(570);
                mark.TextAlign = ContentAlignment.MiddleLeft;
                //---------+----
                Button go = new Button();
                go.Size = new Size(60, 60);
                go.Location = new Point(630, 10);
                go.Text = "Пройти";
                // -------------
                p.Controls.Add(name);
                p.Controls.Add(mark);
                p.Controls.Add(go);
                go.Name = "g" + (i + 1);
                go.Click += new EventHandler(this.g_button_click);
                panel.Controls.Add(p);
            }
        }
        void g_button_click(object sender , EventArgs e)
        {
            //пройти нажате
            Button btn = sender as Button;
            StructFile.goS = int.Parse(btn.Name.Remove(0, 1)) - 1;
            StructFile.curTest = 0;
            StructFile.qq = StructFile.T.allT[StructFile.goS];

            Close();
            TestGo t = new TestGo();
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
