using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GKLab3.Models;

namespace GKLab3.Methods
{
    public class AverageDithering : IMethod
    {
        private long[] rValues;
        private long[] gValues;
        private long[] bValues;
        private int[] numOfR;
        private int[] numOfG;
        private int[] numOfB;
        private int rLength;
        private int gLength;
        private int bLength;
        public string Name
        {
            get
            {
                return "Average dithering";
            }
        }

        public Bitmap GenerateBitmap(RGBColor[,] colors)
        {
            int width = colors.GetLength(0);
            int height = colors.GetLength(1);
            Bitmap bitmap = new Bitmap(width, height);
            int rLength, gLength, bLength;
            rLength = 255 / RGBColor.NumOfR;
            gLength = 255 / RGBColor.NumOfG;
            bLength = 255 / RGBColor.NumOfB;

            for (int i = 0; i < colors.GetLength(0); i++)
            {
                for (int j = 0; j < colors.GetLength(1); j++)
                {
                    bitmap.SetPixel(i, j, Color.FromArgb(
                        CountColorValue(colors[i, j].R, rLength, RGBColor.NumOfR),
                        CountColorValue(colors[i, j].G, gLength, RGBColor.NumOfG),
                        CountColorValue(colors[i, j].B, bLength, RGBColor.NumOfB)
                        ));
                }
            }

            return bitmap;
        }

        public int CountColorValue(int color, int length, int number)
        {
            for (int i = 1; i < number; i++)
            {
                if (color <= length * i)
                {
                    return length * (i-1);
                }
            }
            return 255;
        }
    }
}
