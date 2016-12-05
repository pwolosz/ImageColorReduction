using GKLab3.FIlters;
using GKLab3.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GKLab3.Methods
{
    public class PopularityAlgorithm:IMethod
    {
        public string Name { get { return "Popularity algorithm"; } }

        //Metoda zwracająca bitmapę po zastosowaniu redukcji kolorów metodą algorytmu popularnościowego
        public Bitmap GenerateBitmap(RGBColor[,] colors, IFilter filter)
        {
            //szerokość i wysokość obrazu
            int width = colors.GetLength(0);
            int height = colors.GetLength(1);
            Bitmap bitmap = new Bitmap(width, height);

            //tablica w której będziemy zapisywać ilość wystąpień określonych kolorów
            int[,,] histogram = new int[256, 256, 256];

            //lista aktywnych kolorów tzn tych które wystąpiły w obrazie
            List<ColorEntity> activeColors = new List<ColorEntity>();
            RGBColor currentColor;

            //zliczamy wystąpienia kolorów
            for(int i=0;i<width;i++)
            {
                for(int j=0;j<height;j++)
                {
                    currentColor = colors[i, j];
                    //jeśli dany kolor jeszcze nie wystąpił to dodajemy go do aktywnych kolorów
                    if(histogram[currentColor.R,currentColor.G,currentColor.B] == 0)
                    {
                        activeColors.Add(new ColorEntity(currentColor));
                    }
                    histogram[currentColor.R, currentColor.G, currentColor.B]++;
                }
            }

            //dla każdego z aktywnych kolorów przypisujemy mu ilość wystąpień na bitmapie
            foreach(var c in activeColors)
            {
                c.Count = histogram[c.RGBColor.R, c.RGBColor.G, c.RGBColor.B];
            }

            //sortujemy aktywne kolory i ucinamy do zadanej liczby kolorów
            activeColors.Sort();
            if (activeColors.Count > RGBColor.NumOfColors)
            {
                activeColors.RemoveRange(RGBColor.NumOfColors, activeColors.Count - RGBColor.NumOfColors);
            }

            //tworzymy nową bitmapę o zredukowanej ilości kolorów
            for(int i=0;i<width;i++)
            {
                for(int j = 0;j<height;j++)
                {
                    RGBColor closestColor = colors[i, j].FindClosestColor(activeColors);
                    bitmap.SetPixel(i, j, closestColor.GetColor());
                }
            }

            return bitmap;
        }
    }
}
