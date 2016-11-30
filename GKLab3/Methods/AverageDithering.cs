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

        private void InitValues()
        {
            rValues = new long[RGBColor.NumOfR];
            gValues = new long[RGBColor.NumOfG];
            bValues = new long[RGBColor.NumOfB];
            numOfB = new int[RGBColor.NumOfB];
            numOfG = new int[RGBColor.NumOfG];
            numOfR = new int[RGBColor.NumOfR];
            rLength = 255 / RGBColor.NumOfR;
            gLength = 255 / RGBColor.NumOfG;
            bLength = 255 / RGBColor.NumOfB;
        }


        public Bitmap GenerateBitmap(RGBColor[,] colors)
        {
            InitValues();
            int width = colors.GetLength(0);
            int height = colors.GetLength(1);
            Bitmap bitmap = new Bitmap(width, height);
            CalculateAverage(colors);

            for(int i=0;i<width;i++)
            {
                for(int j=0;j<height;j++)
                {
                    bitmap.SetPixel(i, j, Color.FromArgb(
                        (int)CalculateValue(rValues, rLength, colors[i, j].R),
                        (int)CalculateValue(gValues, gLength, colors[i, j].G),
                        (int)CalculateValue(bValues, bLength, colors[i, j].B)
                        ));
                }
            }

            return bitmap;
        }

        private void CalculateAverage(RGBColor[,] colors)
        {
            for(int i=0;i<colors.GetLength(0);i++)
            {
                for(int j=0;j<colors.GetLength(1);j++)
                {
                    for(int k=0;k<rValues.Length;k++)
                    {
                        if((k + 1) * rLength + 1 >= colors[i, j].R)
                        {
                            rValues[k] += colors[i, j].R;
                            numOfR[k]++;
                            break;
                        }
                    }
                    
                    for (int k = 0; k < gValues.Length; k++)
                    {
                        if ((k + 1) * rLength + 1 >= colors[i, j].R)
                        {
                            gValues[k] += colors[i, j].R;
                            numOfG[k]++;
                            break;
                        }
                    }
                    
                    for (int k = 0; k < bValues.Length; k++)
                    {
                        if ((k + 1) * bLength + 1 >= colors[i, j].R)
                        {
                            bValues[k] += colors[i, j].R;
                            numOfB[k]++;
                            break;
                        }
                    }
                }
            }

            for(int i=0;i<rValues.Length;i++)
            {
                rValues[i] = rValues[i] / numOfR[i];
            }
            for (int i = 0; i < gValues.Length; i++)
            {
                gValues[i] = gValues[i] / numOfG[i];
            }
            for (int i = 0; i < bValues.Length; i++)
            {
                bValues[i] = bValues[i] / numOfB[i];
            }
        }

        private long CalculateValue(long[] values,int length, int value)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if((i+1)*length>=value)
                {
                    return values[i];
                }
            }
            return 255;
        }

        //public Bitmap GenerateBitmap(RGBColor[,] colors)
        //{
        //    int width = colors.GetLength(0);
        //    int height = colors.GetLength(1);
        //    Bitmap bitmap = new Bitmap(width, height);
        //    int rLength, gLength, bLength;
        //    rLength = 255 / RGBColor.NumOfR;
        //    gLength = 255 / RGBColor.NumOfG;
        //    bLength = 255 / RGBColor.NumOfB;

        //    for(int i=0;i<colors.GetLength(0);i++)
        //    {
        //        for(int j=0;j<colors.GetLength(1);j++)
        //        {
        //            bitmap.SetPixel(i, j, Color.FromArgb(
        //                CountColorValue(colors[i, j].R, rLength, RGBColor.NumOfR),
        //                CountColorValue(colors[i, j].G, gLength, RGBColor.NumOfG),
        //                CountColorValue(colors[i, j].B, bLength, RGBColor.NumOfB)
        //                ));
        //        }
        //    }

        //    return bitmap;
        //}

        //public int CountColorValue(int color, int length, int number)
        //{
        //    for(int i=1;i< number;i++)
        //    {
        //        if(color<=length*i)
        //        {
        //            return length * i;
        //        }
        //    }
        //    return 255;
        //}
    }
}
