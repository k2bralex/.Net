using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_02
{
    class Client
    {
        private string Name { get; set; }
        private int Age { get; set; }
        private int INN { get; set; }

        public int GetINN()
        {
            return INN;
        }

        public Client()
        {
            Name = "Smith";
            Age = 25;
            INN = 32323232;
        }

        public override string ToString()
        {
            return $"Name: {Name} | Age: {Age} | INN: {INN}";
        }
    }
}
