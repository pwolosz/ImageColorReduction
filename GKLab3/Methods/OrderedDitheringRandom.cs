using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GKLab3.FIlters;
using GKLab3.Models;
using GKLab3.Matrices;

namespace GKLab3.Methods
{
    public class OrderedDitheringRandom : IMethod
    {
        private int[,] Matrix { get; set; }
        private int n;

        public string Name
        {
            get
            {
                return "Random dithering";
            }
        }

        public Bitmap GenerateBitmap(RGBColor[,] colors, IFilter filter)
        {
            int width = colors.GetLength(0);
            int height = colors.GetLength(1);
            Bitmap bitmap = new Bitmap(width, height);
            Matrix = DitheringMatrix.GetMatrix(RGBColor.K, out n);
            int[] availableColors = GetColors();
            Random rand = new Random();
            int colR, colG, colB, reR, reG, reB, x, y;
            int n2 = n * n;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    colR = colors[i, j].R / n2;
                    colG = colors[i, j].G / n2;
                    colB = colors[i, j].B / n2;
                    reR = colors[i, j].R % n2;
                    reG = colors[i, j].G % n2;
                    reB = colors[i, j].B % n2;

                    x = rand.Next(n);
                    y = rand.Next(n);

                    bitmap.SetPixel(i, j, Color.FromArgb(
                            availableColors[(reR > Matrix[x, y]) ? colR + 1 : colR],
                            availableColors[(reG > Matrix[x, y]) ? colG + 1 : colG],
                            availableColors[(reB > Matrix[x, y]) ? colB + 1 : colB]
                        ));
                }
            }

            return bitmap;
        }

        private int[] GetColors()
        {
            int[] colors = new int[RGBColor.K];
            int length = 255 / RGBColor.K;
            colors[0] = 0;

            for (int i = 1; i < RGBColor.K - 1; i++)
            {
                colors[i] = colors[i - 1] + length;
            }
            colors[RGBColor.K - 1] = 255;

            return colors;
        }
    }
}
