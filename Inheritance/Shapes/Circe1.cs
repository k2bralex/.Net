using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Shapes
{
    class Circe1 : Shape
    {
        public Circe1(string name):base(name)
        {
            
        }
        public override void Draw()
        {
            Console.WriteLine($"Drawing {PetName} the Circle");
        }
    }
}
