﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chasi
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Bitmap bitmap_2;
        Graphics g;
        Graphics gr;
        Timer timer;
        int x = 209, y = 60;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            bitmap_2 = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            g = Graphics.FromImage(pictureBox1.Image = bitmap);
            gr = Graphics.FromImage(pictureBox2.Image = bitmap_2);
            timer = new Timer();
            timer.Interval = 1000;
            timer.Start();
            timer.Tick += Timer_Tick;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
