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
    public partial class Main : Form
    {
        private static VideoCapture cap = new VideoCapture();
        private static Queue<Image<Emgu.CV.Structure.Bgr, Byte>> queue = new Queue<Image<Emgu.CV.Structure.Bgr, Byte>>(2);
        private static Timer t = new Timer();
        public Main()
        {
            InitializeComponent();
            MySharedInfo.constructor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Yes, I am using .text as a boolean variable. Fight me.
            if (button1.Text.Equals("Start"))
            {
                button1.Text = "Stop";
                t.Tick += imageCompare;
                t.Interval = (int)(MySharedInfo.interval * 1000);
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
            queue.Enqueue(cap.QueryFrame().ToImage<Emgu.CV.Structure.Bgr, Byte>(false));
            imageBox1.Image = queue.Peek().Resize(imageBox1.Width, imageBox1.Height, Emgu.CV.CvEnum.Inter.Lanczos4);
            imageBox2.Image = queue.Last().Resize(imageBox1.Width, imageBox1.Height, Emgu.CV.CvEnum.Inter.Lanczos4);
            if (queue.Count > 1)
            {
                Emgu.CV.Mat imageHashOne = new Mat(), imageHashTwo = new Mat();
                Image<Emgu.CV.Structure.Bgr, Byte> a = queue.Dequeue();
                Image<Emgu.CV.Structure.Bgr, Byte> b = queue.Peek();

                //This is apparently the best hash method
                MarrHildrethHash t = new Emgu.CV.ImgHash.MarrHildrethHash();
                t.Compute(a, imageHashOne);
                t.Compute(b, imageHashTwo);
                double percentageImageSimilarity = t.Compare(imageHashOne, imageHashTwo);
                double er = 100 - percentageImageSimilarity;
                if (percentageImageSimilarity < MySharedInfo.marginError)
                {
                    label1.Text = "True";


                }
                else
                {
                    label1.Text = "False";
                    imageSaveHandle(b);
                }
            }
            else { label1.Text = "True"; }

        }

        private static void imageSaveHandle(Image<Emgu.CV.Structure.Bgr, Byte> image)
        {
            string Oldfile = "";
            if (!Directory.Exists(MySharedInfo.dir))
            {
                Directory.CreateDirectory(MySharedInfo.dir);
            }
            string[] files = Directory.GetFiles(MySharedInfo.dir);
            if (files.Length >= MySharedInfo.numPhotos)
            {
                foreach (string file in files)
                {
                    if (Oldfile.Equals("") || File.GetCreationTime(file) > File.GetCreationTime(Oldfile))
                    {
                        Oldfile = file;
                    }
                }
                //Overwrites the oldest file in the directory
                image.Save(Oldfile);
            }
            else
            {
                image.Save(MySharedInfo.dir + "Image" + MySharedInfo.currPhoto++ + ".png");
            }

        }

        private void settingsButton(object sender, EventArgs e)
        {
            Settings f2 = new Settings();
            f2.ShowDialog();
        }
    }

    internal static class MySharedInfo
    {
        public static void constructor()
        {
            marginError = 15;
            interval = 5;
            numPhotos = 5;
            dir = ".//SavedPhotos//";
            currPhoto = 0;
        }

        public static int marginError;
        public static int interval;
        public static int numPhotos;
        public static string dir;
        public static int currPhoto;


    }
}
