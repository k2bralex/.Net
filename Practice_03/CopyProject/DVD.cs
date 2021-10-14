using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_03.CopyProject
{
    class Dvd : Storage
    {
        private double ReadSpeed { get; set; }
        private double WriteSpeed { get; set; }
        private double MemorySize { get; set; }
        private double FreeMemorySize { get; set; }
        
        public Dvd(string name,string model):base(name,model)
        {
            switch (model)
            {
                case "Oneside":
                {
                    MemorySize = 4.7;
                    FreeMemorySize = MemorySize;
                    WriteSpeed = 2.2;
                    ReadSpeed = 4.4;
                }
                    break;
                case "Bothside":
                {
                    MemorySize = 9.00;
                    FreeMemorySize = MemorySize;
                    WriteSpeed = 1.2;
                    ReadSpeed = 2.4;
                    } break;
            }
        }

        public override double GetWriteSpeed()
        {
            return WriteSpeed;
        }

        public override double GetMemory()
        {
            return MemorySize;
        }

        public override void CopyData(int dataSize)
        {
            Console.WriteLine(dataSize <= MemorySize ? "Writing data" : $"Not enouth memory");

            FreeMemorySize = MemorySize - dataSize;
        }

        public override double GetFreeMemory()
        {
            return FreeMemorySize;
        }

        public override void GetFullInfo()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"{base.ToString()} |  Memory Size: {MemorySize} |" +
                   $" Free Memory Size: {FreeMemorySize} | Write Speed: " +
                   $"{WriteSpeed} | Read Speed: {ReadSpeed}";
        }
    }
}
