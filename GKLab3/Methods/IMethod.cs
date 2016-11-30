using GKLab3.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GKLab3.Methods
{
    public interface IMethod
    {
        Bitmap GenerateBitmap(RGBColor[,] colors);
        
        string Name { get;}
    }
}
