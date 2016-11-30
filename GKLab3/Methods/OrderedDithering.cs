using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GKLab3.Models;

namespace GKLab3.Methods
{
    public class OrderedDithering : IMethod
    {
        public string Name
        {
            get
            {
                return "Ordered dithering";
            }
        }

        public Bitmap GenerateBitmap(RGBColor[,] colors)
        {
            int width = colors.GetLength(0);
            int height = colors.GetLength(1);
            Bitmap bitmap = new Bitmap(width, height);


            return bitmap;
        }
    }
}
