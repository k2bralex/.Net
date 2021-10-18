using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urok_6
{
    interface SimpleNAngle
    {
        double Hight { get; set; }
        double Base { get; set; }
        double Angle { get; set; }
        int SidesQuantity { get; set; }
        double[] SidesLenght { get; set; }
        double Area { get; set; }
        double Perimeter { get; set; }
    }
}
