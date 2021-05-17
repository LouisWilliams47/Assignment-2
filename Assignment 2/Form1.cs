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
                double Area = 2.0 * (length * width + length * Height + width + height);
                double Volume = length * width * height;
                //d
                label1.Text = "surface area" + Area;
                label2.Text = "volume" + Volume;
            }
            catch
            {
                // show error message on screen if fail
                MessageBox.Show("Evy kid you");
            }
        }
    }
    }
