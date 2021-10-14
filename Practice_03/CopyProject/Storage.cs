using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_03.CopyProject
{
    abstract class Storage
    {
        private string Name { get; set; }
        private string Model { get; set; }

        protected Storage(string name, string model)
        {
            Name = name;
            Model = model;
        }

        public abstract double GetWriteSpeed();
        public abstract double GetMemory();
        public abstract void CopyData(int dataSize);
        public abstract double GetFreeMemory();
        public abstract void GetFullInfo();

        public override string ToString()
        {
            return $"Name: {Name} | Model: {Model}";
        }
    }
}
