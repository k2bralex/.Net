using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_03.CopyProject
{
    class Flash : Storage
    {
        private double ReadSpeed { get; set; }
        private double WriteSpeed { get; set; }
        private double MemorySize { get; set; }
        private double FreeMemorySize { get; set; }
        public Flash(string name, string model, double memorySize) : base(name, model)
        {
            MemorySize = memorySize;
            FreeMemorySize = MemorySize;
            switch (model)
            {
                case "USB 2.0":
                {
                    WriteSpeed = 5.22;
                    ReadSpeed = 8.44;
                }
                    break;
                case "USB 3.0":
                {
                    WriteSpeed = 10.88;
                    ReadSpeed = 18.30;
                }
                    break;
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
