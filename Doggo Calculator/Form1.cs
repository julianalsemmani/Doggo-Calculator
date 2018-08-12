using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doggo_Calculator
{
    public partial class Form1 : Form
    {
        public int multiplyAge = 7;
        public int dogAge;
        public int dogFirstYear = 15;
        public int dogSecondYear = 24;
        public int dogAgeFour = 4;
        public int afterTwoYears = 24;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Calculates the age

            if (int.TryParse(textBox1.Text, out dogAge))
            {
                if (dogAge == 1)
                {
                    label3.Text = dogFirstYear + " years old";
                    label4.Text = " ";
                } else if (dogAge == 2)
                {
                    label3.Text = dogSecondYear + " years old";
                    label4.Text = " ";
                } else if (dogAge > 2)
                {
                    int dogAgeDone = afterTwoYears + ((dogAge - 2) * dogAgeFour);
                    label3.Text = dogAgeDone + " years old";
                    label4.Text = " ";
                } else if (dogAge < 1)
                {
                    label3.Text = "1 year or more.";
                    label4.Text = " ";
                }
            }
            else if (!int.TryParse(textBox1.Text, out dogAge))
            {
                label3.Text = "Invalid.";
                label4.Text = "Try again.";
            }

            // Old Algorithm
            /*  int total = dogAge * multiplyAge;
                label3.Text = total + " years old";
                label4.Text = " ";  */
        }

        private void iconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Redirects to webpage.
            System.Diagnostics.Process.Start("http://www.iconarchive.com/show/noto-emoji-animals-nature-icons-by-google/22214-dog-face-icon.html");
        }

        private void githubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Redirects to webpage.
            System.Diagnostics.Process.Start("https://github.com/jillokdev");
        }

        private void pictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Redirects to webpage.
            System.Diagnostics.Process.Start("http://weegeepedia.wikia.com/wiki/File:Mlg_Doge.png");
        }
    }
}
