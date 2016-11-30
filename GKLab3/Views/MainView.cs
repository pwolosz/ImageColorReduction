using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GKLab3.Models;
using GKLab3.Methods;

namespace GKLab3.Views
{
    public partial class mainView : Form
    {
        public Bitmap BeforeBitmap { get; set; }
        public Bitmap AfterBitmap { get; set; }
        public RGBColor[,] RGBColors { get; set; }
        public IMethod Method { get; set; }

        public mainView()
        {
            InitializeComponent();
            InitControls();
        }

        private void InitControls()
        {
            List<IMethod> methods = new List<IMethod>() {
                new PopularityAlgorithm(),
                new AverageDithering(),
                new OrderedDithering()
            };

            methodsComboBox.DataSource = methods;
            methodsComboBox.DisplayMember = "Name";
        }

        private void LoadImageButtonClick(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Select image";
            fileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *bmp, *gif) | *.jpg; *.jpeg; *.png; *.bmp; *.gif;";

            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                BeforeBitmap = (Bitmap)Image.FromFile(fileDialog.FileName);
                beforeImagePictureBox.Size = BeforeBitmap.Size;
                beforeImagePictureBox.Image = BeforeBitmap;
                InitRgbColors();
            }
        }

        private void InitRgbColors()
        {
            if(this.BeforeBitmap != null)
            {
                int x = BeforeBitmap.Width;
                int y = BeforeBitmap.Height;
                RGBColors = new RGBColor[x,y];

                for(int i = 0;i< x;i++)
                {
                    for(int j = 0;j< y;j++)
                    {
                        Color color = BeforeBitmap.GetPixel(i, j);
                        RGBColors[i, j] = new RGBColor(color.R, color.G, color.B);
                    }
                }
            }
        }

        private void UseMethod()
        {
            int colors, r, g, b;
            if (BeforeBitmap != null && Method != null)
            {
                if(!int.TryParse(colorsTextBox.Text,out colors))
                {
                    colors = 2;
                }
                if (!int.TryParse(rTextBox.Text, out r))
                {
                    r = 2;
                }
                if (!int.TryParse(gTextBox.Text, out g))
                {
                    g = 2;
                }
                if (!int.TryParse(bTextBox.Text, out b))
                {
                    b = 2;
                }

                RGBColor.NumOfB = b;
                RGBColor.NumOfColors = colors;
                RGBColor.NumOfG = g;
                RGBColor.NumOfR = r;

                AfterReductionWindow afterReductionWindow = new AfterReductionWindow(Method.GenerateBitmap(RGBColors));
                afterReductionWindow.Show(this);
            }
        }

        private void ChangeMethod(object sender, EventArgs e)
        {
            Method = (IMethod)methodsComboBox.SelectedItem;
        }

        private void textBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ReduceColorsClick(object sender, EventArgs e)
        {
            UseMethod();
        }
    }
}
