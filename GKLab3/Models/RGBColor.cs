using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GKLab3.Models
{
    //klasa służąca przechowywaniu koloru
    public class RGBColor
    {
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
        public static int NumOfColors { get; set; }
        public static int NumOfR { get; set; }
        public static int NumOfG { get; set; }
        public static int NumOfB { get; set; }

        public RGBColor(int r, int g, int b)
        {
            this.R = r;
            this.G = g;
            this.B = b;
        }

        //zwraca kolor 
        public Color GetColor()
        {
            return Color.FromArgb(R, G, B);
        }

        //zwraca kolor o wartościach R,G,B będących różnicą tych wartości w podanych kolorach
        public static RGBColor operator-(RGBColor color1, RGBColor color2)
        {
            return new RGBColor(color1.R - color2.R, color1.G - color2.G, color1.B - color2.B);
        }

        //zwraca kolor o wartościach R,G,B będących sumą tych wartości w podanych kolorach
        public static RGBColor operator+(RGBColor color1, RGBColor color2)
        {
            return new RGBColor(color1.R + color2.R, color1.G + color2.G, color1.B + color2.B);
        }

        //sprawdza który kolor jest "mniejszy"
        public static bool operator<(RGBColor color1, RGBColor color2)
        {
            return (color1.R < color2.R) || (color1.G < color2.G) || (color1.B < color2.B);
        }

        //sprawdza który kolor jest "większy"
        public static bool operator>(RGBColor color1, RGBColor color2)
        {
            return (color1.R > color2.R) || (color1.G > color2.G) || (color1.B > color2.B);
        }

        //znajduje najbliższy kolor wśród podanych kolorów (metryka euklidesowa)
        public RGBColor FindClosestColor(List<ColorEntity> colors)
        {
            int minDistance = int.MaxValue;
            int distance;
            RGBColor foundColor = null;

            foreach(var c in colors)
            {
                if (c.RGBColor.R == this.R && c.RGBColor.G == c.RGBColor.G && c.RGBColor.B == c.RGBColor.B)
                    return c.RGBColor;

                distance = (c.RGBColor.R - this.R) * (c.RGBColor.R - this.R)
                    + (c.RGBColor.G - this.G) * (c.RGBColor.G - this.G)
                    + (c.RGBColor.B - this.B) * (c.RGBColor.B - this.B);

                if(distance<minDistance)
                {
                    foundColor = c.RGBColor;
                    minDistance = distance;
                }
            }

            return foundColor;
        }

        
    }

}
