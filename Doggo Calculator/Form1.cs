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
        public int multiplyAge = 9;
        public int dogAge;

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
                int total = dogAge * multiplyAge;
                label3.Text = total + " years old";
                label4.Text = " ";
            } else if (!int.TryParse(textBox1.Text, out dogAge))
            {
                label3.Text = "Invalid.";
                label4.Text = "Try again.";
            }
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
