using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS539_6_16_24_first_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UAT Roc ks");
            button2.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int result;
            if (int.TryParse(textBox1.Text, out result))
            {
                MessageBox.Show("This is a valid int");
            }
            else
            {
                MessageBox.Show("This is NOT a valid int");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.uat.edu");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Programming is the BEST");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Databases are used everywhere");

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("We need connnectivity");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
                {
                MessageBox.Show("You are above average");

                }
            else
            {
                MessageBox.Show("You are ok");
            }
        }
    }
}
