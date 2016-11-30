using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GKLab3.Views
{
    public partial class AfterReductionWindow : Form
    {
        public AfterReductionWindow(Bitmap bitmap)
        {
            InitializeComponent();
            this.imagePictureBox.Size = new Size(bitmap.Width, bitmap.Height);
            this.imagePictureBox.Image = bitmap;
        }
    }
}
