﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace move_picture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
















        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X + 5 < ClientRectangle.Width - pictureBox1.Width)

        {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 20, pictureBox1.Location.Y);//this makes the picture move to the right when the user clicks the button called move\\\\
            }

        }
















        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 20, pictureBox1.Location.Y);
            }
        }






















        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y > 0)



            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 10);
            }
        }




















        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y - 5 < ClientRectangle.Height - pictureBox1.Height)




            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 10);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
