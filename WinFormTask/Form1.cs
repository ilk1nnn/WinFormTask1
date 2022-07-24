using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTask
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            timer.Tick += button1_Click;
            timer.Start();
            if (DateTime.Now.Minute <= 9 && DateTime.Now.Second <= 9)
            {
                label3.Text = $@"                           in Baku => {DateTime.Now.Hour}:0{DateTime.Now.Minute}:0{DateTime.Now.Second}";
            }                                               
            if (DateTime.Now.Second <= 9)                   
            {                                               
                                                            
                label3.Text = $@"                           in Baku => {DateTime.Now.Hour}:{DateTime.Now.Minute}:0{DateTime.Now.Second}";
            }                                               
            else                                            
            {                                               
                label3.Text = $@"                           in Baku => {DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}";
                                                            
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            timer.Tick += button2_Click;
            timer.Start();
            if(DateTime.Now.Minute<=9 && DateTime.Now.Second <= 9)
            {
                label3.Text = $@"                          in London => {DateTime.Now.Hour - 3}:0{DateTime.Now.Minute}:0{DateTime.Now.Second}";
            }                                              
            if (DateTime.Now.Second <= 9)                  
            {                                              
                                                           
                label3.Text = $@"                          in London => {DateTime.Now.Hour - 3}:{DateTime.Now.Minute}:0{DateTime.Now.Second}";
            }                                              
            else                                           
            {                                              
                label3.Text = $@"                          in London => {DateTime.Now.Hour - 3}:{DateTime.Now.Minute}:{DateTime.Now.Second}";

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomX = random.Next((this.Size.Width) - 100);
            int randomY = random.Next((this.Size.Height/2)+1, this.Size.Height-100);
            button3.Location = new Point(randomX, randomY);
            Random rnd = new Random();
            int num1 = rnd.Next(0, 256);
            int num2 = rnd.Next(0, 256);
            int num3 = rnd.Next(0, 256);
            button3.Text = " ";
            button3.BackColor = Color.FromArgb(num1, num2, num3);
        }
    }
}
