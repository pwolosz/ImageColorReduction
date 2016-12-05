using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GKLab3.FIlters
{
    public class Burkes : IFilter
    {
        public float[,] Filter { get; set; }

        public string Name
        {
            get
            {
                return "Burkes";
            }
        }

        public Burkes()
        {
            this.Filter = new float[3, 5];
            this.Filter[1, 3] = (float)8 / 32;
            this.Filter[1, 4] = (float)4 / 32;
            this.Filter[2, 0] = (float)2 / 32;
            this.Filter[2, 1] = (float)4 / 32;
            this.Filter[2, 2] = (float)8 / 32;
            this.Filter[2, 3] = (float)4 / 32;
            this.Filter[2, 4] = (float)2 / 32;
        }
    }
}
