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
using CoenM.ImageHash;
using Emgu.CV;
using Emgu.CV.ImgHash;
using System.Collections;

namespace ImageHashingApp
{
    public partial class Form1 : Form
    {
        private static VideoCapture cap;
        private static Queue<Emgu.CV.Mat> queue;
        private static Timer t;
        private bool exitFlag = true;
        public Form1()
        {
            InitializeComponent();
            cap = new VideoCapture();
            queue = new Queue<Emgu.CV.Mat>(2);
            t = new Timer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Yes, I am using .text as a boolean variable. Fight me.
            if (button1.Text.Equals("Start"))
            {
                button1.Text = "Stop";
                exitFlag = true;
                t.Tick += imageCompare;
                t.Interval = (int)(numericUpDown2.Value * 1000);
                t.Enabled = true;
                t.Start();
            }
            else
            {
                t.Stop();
                button1.Text = "Start";
                // Processes all the events in the queue.
                Application.DoEvents();
            }
        }

        private void imageCompare(Object source, EventArgs e)
        {
            queue.Enqueue(cap.QueryFrame());
            imageBox1.Image = queue.Peek().ToImage<Emgu.CV.Structure.Bgr, Byte>(false).Resize(imageBox1.Width, imageBox1.Height, Emgu.CV.CvEnum.Inter.Lanczos4);
            imageBox2.Image = queue.Last().ToImage<Emgu.CV.Structure.Bgr, Byte>(false).Resize(imageBox1.Width, imageBox1.Height, Emgu.CV.CvEnum.Inter.Lanczos4);
            if (queue.Count > 1)
            {
                Emgu.CV.Mat imageHashOne = new Mat(), imageHashTwo = new Mat();
                Emgu.CV.Mat a = queue.Dequeue();
                Emgu.CV.Mat b = queue.Peek();

                //This is apparently the best hash method
                MarrHildrethHash t = new Emgu.CV.ImgHash.MarrHildrethHash();
                t.Compute(a, imageHashOne);
                t.Compute(b, imageHashTwo);
                double percentageImageSimilarity = t.Compare(imageHashOne, imageHashTwo);
                double er = 100 - percentageImageSimilarity;
                if (percentageImageSimilarity < (int)numericUpDown1.Value)
                {
                    label1.Text = "True";
                }
                else
                {
                    label1.Text = "False";
                }
            }
            else { label1.Text = "False"; }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void imageBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
