using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GKLab3.FIlters
{
    public interface IFilter
    {
        float[,] Filter { get; set; }

        string Name { get; }
    }
}
