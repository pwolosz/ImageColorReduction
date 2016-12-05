using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GKLab3.Models;
using GKLab3.FIlters;

namespace GKLab3.Methods
{
    public class ErrorDiffusion : IMethod
    {
        private float[,,] Errors;
        private float[,] Filter;
        private int width;
        private int height;

        public string Name
        {
            get
            {
                return "Error Diffusion";
            }
        }

        public Bitmap GenerateBitmap(RGBColor[,] colors, IFilter filter)
        {
            width = colors.GetLength(0);
            height = colors.GetLength(1);
            Bitmap bitmap = new Bitmap(width, height);
            Errors = new float[3,width, height];
            Filter = filter.Filter;
            int error = 0,r,g,b;
            Color color;
            int gLength = 255 / RGBColor.NumOfR;
            int rLength = 255 / RGBColor.NumOfG;
            int bLength = 255 / RGBColor.NumOfB;
            int[,] rs = new int[width, height];
            int[,] gs = new int[width, height];
            int[,] bs = new int[width, height];
            for (int i=0;i<width;i++)
            {
                for(int j=0;j<height;j++)
                {
                    r = CalculateColorValue(colors[i, j].R + (int)Errors[0, i, j], rLength, RGBColor.NumOfR, out error);
                    PropagateError(0, error, i, j);
                    rs[i, j] = r;
                    g = CalculateColorValue(colors[i, j].G + (int)Errors[1, i, j], gLength, RGBColor.NumOfG, out error);
                    PropagateError(1, error, i, j);
                    gs[i, j] = g;
                    b = CalculateColorValue(colors[i, j].B + (int)Errors[2, i, j], bLength, RGBColor.NumOfB, out error);
                    PropagateError(2, error, i, j);
                    bs[i, j] = b;
                    bitmap.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }
            int rc=0, gc=0, bc=0;
            for(int i=0;i<width;i++)
            {
                for(int j=0;j<height;j++)
                {
                    if (rs[i, j] != 0 && rs[i, j] != 255)
                        rc++;
                    if (bs[i, j] != 0 && bs[i, j] != 255)
                        bc++;
                    if (gs[i, j] != 0 && gs[i, j] != 255)
                        gc++;
                }
            }
            int a = rc;
            int bb = bc;
            int c = gc;
            return bitmap;
        }

        private int CalculateColorValue(int color, int length, int number, out int error)
        {
            error = 0;
            for (int i = 1; i < number; i++)
            {
                if (color <= length * i)
                {
                    error = color - length * (i - 1);
                    return length * (i - 1);
                }
            }
            error = color - 255;
            return 255;
        }

        private void PropagateError(int hue, int value, int currentPixelX, int currentPixelY)
        {
            int xLength = Filter.GetLength(0) / 2;
            int yLength = Filter.GetLength(1) / 2;
            for (int i = -xLength; i <= xLength; i++)
            {
                for (int j = -yLength; j <= yLength; j++)
                {
                    if (currentPixelX + i < width && currentPixelY + j < height && currentPixelX+i>=0 && currentPixelY+j>=0)
                    {
                        float v = Filter[i + xLength , j + yLength] * value;
                        Errors[hue, currentPixelX + i, currentPixelY + j] += v;
                    }
                }
            }
        }
    }
}
