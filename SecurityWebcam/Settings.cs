using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageHashingApp;

namespace ImageHashingApp
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            TimeDropdown.Value = MySharedInfo.interval;
            MarginErrorDropdown.Value = MySharedInfo.marginError;
            NumPhotosDropdown.Value = MySharedInfo.numPhotos;
            directoryBox.Text = MySharedInfo.dir;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySharedInfo.interval = (int)TimeDropdown.Value;
            MySharedInfo.marginError = (int)MarginErrorDropdown.Value;
            MySharedInfo.numPhotos = (int)NumPhotosDropdown.Value;
            MySharedInfo.dir = directoryBox.Text;
            this.Close();
        }
    }
}
