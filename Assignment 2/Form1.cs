using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                //read force and angle from textboxes
                double length = double.Parse(textBox1.Text);
                double width = double.Parse(textBox2.Text);
                double height = double.Parse(textBox3.Text);
                //
                double Area = 2.0 * (length * width + length * height + width + height);
                double Volume = length * width * height;
                //d
                label1.Text = "surface area" + Area;
                label2.Text = "volume" + Volume;
            }
            catch
            {
                // show error message on screen if fail
                MessageBox.Show("error");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //read force and angle from textboxes
                double radius = double.Parse(textBox4.Text);

                //
                double Area = 4.0 * 3.14 * radius * radius;
                double Volume = 4.0 / 3.0 * 3.14 * radius * radius * radius;
                //d
                label3.Text = "surface area" + Area;
                label5.Text = "volume" + Volume;
            }
            catch
            {
                // show error message on screen if fail
                MessageBox.Show("error");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                //read force and angle from textboxes
                double radius = double.Parse(textBox5.Text);
                double height = double.Parse(textBox6.Text);
                //
                double Area = 3.14 * radius * (radius + Math.Sqrt(height * Height + radius * radius));
                double Volume = 3.14 * radius * radius * height / 3;
                //d
                label6.Text = "area" + Area;
                label7.Text = "volume" + Volume;
            }
            catch
            {
                // show error message on screen if fail
                MessageBox.Show("error");
            }
        }
    }
}