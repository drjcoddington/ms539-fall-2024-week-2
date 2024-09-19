using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * name
 * assignment
 * what was added
 * notes
 * estimate 3 hours
 * actual 1 hours
 * 
 * week 2 
 * estimate 
 * actual 
 */
namespace MS539_9_18_24_images
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int die = rnd.Next(1, 7);
            string path, imagePath;
           

            switch (die)
            {


                case 1:
                    path = Directory.GetCurrentDirectory();
                    imagePath = Path.Combine(path, "images", "dice1.png");
                    pictureBox1.ImageLocation = imagePath;
                    //DO NOT hardcode your directory like below
                    //  imagePath = "C:/jill/ms539/project1";
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;

                case 2:
                    path = Directory.GetCurrentDirectory();
                    imagePath = Path.Combine(path, "images", "dice2.png");
                    pictureBox1.ImageLocation = imagePath;
                    //DO NOT hardcode your directory like below
                    //  imagePath = "C:/jill/ms539/project1";
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case 3:
                    path = Directory.GetCurrentDirectory();
                    imagePath = Path.Combine(path, "images", "dice3.png");
                    pictureBox1.ImageLocation = imagePath;
                    //DO NOT hardcode your directory like below
                    //  imagePath = "C:/jill/ms539/project1";
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case 4:
                    path = Directory.GetCurrentDirectory();
                    imagePath = Path.Combine(path, "images", "dice4.png");
                    pictureBox1.ImageLocation = imagePath;
                    //DO NOT hardcode your directory like below
                    //  imagePath = "C:/jill/ms539/project1";
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case 5:
                    path = Directory.GetCurrentDirectory();
                    imagePath = Path.Combine(path, "images", "dice5.png");
                    pictureBox1.ImageLocation = imagePath;
                    //DO NOT hardcode your directory like below
                    //  imagePath = "C:/jill/ms539/project1";
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case 6:
                    path = Directory.GetCurrentDirectory();
                    imagePath = Path.Combine(path, "images", "dice6.png");
                    pictureBox1.ImageLocation = imagePath;
                    //DO NOT hardcode your directory like below
                    //  imagePath = "C:/jill/ms539/project1";
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                default:
                    MessageBox.Show("error - # >7");
                    break;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
