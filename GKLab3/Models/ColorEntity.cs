using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GKLab3.Models
{
    public class ColorEntity:IComparable
    {
        public int Count { get; set; }
        public RGBColor RGBColor { get; set; }

        public ColorEntity(RGBColor color)
        {
            this.RGBColor = color;
        }

        public int CompareTo(object obj)
        {
            ColorEntity color = (ColorEntity)obj;
            if (this.Count < color.Count)
            {
                return 1;
            }
            if (this.Count > color.Count)
            {
                return -1;
            }
            return 0;
        }

        
    }
}
