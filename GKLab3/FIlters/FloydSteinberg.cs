using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GKLab3.FIlters
{
    public class FloydSteinberg : IFilter
    {
        public float[,] Filter { get; set; }

        public string Name
        {
            get
            {
                return "Floyd and Steinberg";
            }
        }

        public FloydSteinberg()
        {
            this.Filter = new float[3, 3];
            this.Filter[1, 2] = (float)7 / 16;
            this.Filter[2, 0] = (float)3 / 16;
            this.Filter[2, 1] = (float)5 / 16;
            this.Filter[2, 2] = (float)1 / 16;
        }
    }
}
