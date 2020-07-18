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
        private VideoCapture cap;
        Queue<Emgu.CV.Mat> queue;
        public Form1()
        {
            InitializeComponent();
            cap = new VideoCapture();
            queue = new Queue<Emgu.CV.Mat>(2);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            queue.Enqueue(cap.QueryFrame());
            imageBox1.Image = queue.Peek().ToImage<Emgu.CV.Structure.Bgr, Byte>(false).Resize(imageBox1.Width, imageBox1.Height, Emgu.CV.CvEnum.Inter.Lanczos4);
            imageBox2.Image = queue.Last().ToImage<Emgu.CV.Structure.Bgr, Byte>(false).Resize(imageBox1.Width, imageBox1.Height, Emgu.CV.CvEnum.Inter.Lanczos4);
            //string two = "C:\\Users\\seanr\\source\\repos\\ImageHashingApp\\Dog.jpg";
            this.label1.Text = imageCompare().ToString();
        }

        private bool imageCompare()
        {
            if (queue.Count > 1)    
            {
                Emgu.CV.Mat imageHashOne = new Mat(), imageHashTwo = new Mat();
                Emgu.CV.Mat a = queue.Dequeue();
                Emgu.CV.Mat b = queue.Peek();

                AverageHash t = new Emgu.CV.ImgHash.AverageHash();
                t.Compute(a, imageHashOne);
                t.Compute(b, imageHashTwo);
                double percentageImageSimilarity = t.Compare(imageHashOne, imageHashTwo);
                double er = 100 - percentageImageSimilarity;
                if (percentageImageSimilarity < (int)numericUpDown1.Value)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else { return false; }
        }
    
    }
}
