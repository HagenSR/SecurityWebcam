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
using CoenM.ImageHash.HashAlgorithms;

namespace ImageHashingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string one = textBox1.Text;
            string two = textBox2.Text;
            //string two = "C:\\Users\\seanr\\source\\repos\\ImageHashingApp\\Dog.jpg";
            this.label1.Text = imageCompare(one, two, 5).ToString();
        }

        private bool imageCompare(String one, String two, double error)
        {
            ulong imageHashOne, imageHashTwo;

            using (var stream = File.OpenRead(one))
            {
                imageHashOne = ImageHashExtensions.Hash(new AverageHash(), stream);
            }
            using (var stream = File.OpenRead(two))
            {
                imageHashTwo = ImageHashExtensions.Hash(new AverageHash(), stream);
            }

            double percentageImageSimilarity = CompareHash.Similarity(imageHashOne, imageHashTwo);
            double er = 1 - percentageImageSimilarity;
            if (100 - percentageImageSimilarity < (int)numericUpDown1.Value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
