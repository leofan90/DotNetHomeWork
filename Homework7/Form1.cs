using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null)
                graphics = this.CreateGraphics();
            else
                graphics.Clear(this.BackColor);
            drawCayleyTree(Int32.Parse(textBox1.Text), 560, 310, Int32.Parse(textBox2.Text), -Math.PI / 2);
        }

        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;

        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, Double.Parse(textBox3.Text) * leng, th + (Double.Parse(textBox6.Text) * Math.PI / 180));
            drawCayleyTree(n - 1, x1, y1, Double.Parse(textBox4.Text) * leng, th - (Double.Parse(textBox5.Text) * Math.PI / 180));
        }

        void drawLine(double x0, double y0, double x1, double y1)
        {
            switch (comboBox1.Text)
            {
                case "blue":
                    graphics.DrawLine(
                    Pens.Blue,
                    (int)x0, (int)y0, (int)x1, (int)y1
                    );
                    break;
                case "red":
                    graphics.DrawLine(
                    Pens.Red,
                    (int)x0, (int)y0, (int)x1, (int)y1
                    );
                    break;
                case "yellow":
                    graphics.DrawLine(
                    Pens.Yellow,
                    (int)x0, (int)y0, (int)x1, (int)y1
                    );
                    break;
                case "green":
                    graphics.DrawLine(
                    Pens.Green,
                    (int)x0, (int)y0, (int)x1, (int)y1
                    );
                    break;
                case "black":
                    graphics.DrawLine(
                    Pens.Black,
                    (int)x0, (int)y0, (int)x1, (int)y1
                    );
                    break;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
