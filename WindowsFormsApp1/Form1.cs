using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
         Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            titleLbl.Text = "Ilkin";
            timeLbl.Text = DateTime.Now.ToLongTimeString();

            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timeLbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var result = MessageBox.Show("C# is hard or not ?","Lesson",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (result == DialogResult.Yes)
            //{
            //    this.BackColor = Color.Yellow;
            //}
            //else if(result == DialogResult.No)
            //{
            //    this.BackColor = Color.FromArgb(255, 0, 0);
            //}

            Button button = new Button();
            button.Text = "Click Me";
            button.AutoSize = true;
            button.Font = new Font("Comic Sans MS", 25, FontStyle.Italic);
            button.Location = new Point(100, 100);
            button.ForeColor = Color.Brown;

            button.Click += Button_Click;

            this.Controls.Add(button);
        }

        private void Button_Click(object sender, EventArgs e)
        {
           if(sender is Button bt)
            {
                this.Controls.Remove(bt);

                Button button = new Button();
                button.Text = "Click Me";
                button.AutoSize = true;
                button.Font = new Font("Comic Sans MS", 25, FontStyle.Italic);
                var random=new Random();
                var x = random.Next(100, 600);
                var y = random.Next(100, 500);
                button.Location = new Point(x, y);
                button.ForeColor = Color.Brown;
                button.Click += Button_Click;

                this.Controls.Add(button);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        //private void timeLbl_Click(object sender, EventArgs e)
        //{
        //    timer.Stop();
        //}
    }
}
