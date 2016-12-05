using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GKLab3.FIlters
{
    public class Stucky : IFilter
    {
        public float[,] Filter { get; set; }

        public string Name
        {
            get
            {
                return "Stucky";
            }
        }

        public Stucky()
        {
            this.Filter = new float[5,5];
            this.Filter[2, 3] = (float)8 / 42;
            this.Filter[2, 4] = (float)4 / 42;
            this.Filter[3, 0] = (float)2 / 42;
            this.Filter[3, 1] = (float)4 / 42;
            this.Filter[3, 2] = (float)8 / 42;
            this.Filter[3, 3] = (float)4 / 42;
            this.Filter[3, 4] = (float)2 / 42;
            this.Filter[4, 0] = (float)1 / 42;
            this.Filter[4, 1] = (float)2 / 42;
            this.Filter[4, 2] = (float)4 / 42;
            this.Filter[4, 3] = (float)2 / 42;
            this.Filter[4, 4] = (float)1 / 42;
        }
    }
}
