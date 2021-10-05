using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Shapes
{
    class Side
    {
        double _lenght;

        public double Lenght
        {
            get => _lenght;
            set => _lenght = value;
        }

        public Side(double lenght)
        {
            _lenght = lenght;
        }

    }
}
