using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum DVDModel
{
    Oneside, Bothside
}

namespace Practice_03.CopyProject
{
    class BurningRom
    {
        private Storage [] RomStorage { get; set; }

        public BurningRom()
        {
            RomStorage = new Storage[3];
            RomStorage[0] = new Dvd("DVD", "Bothside");
            RomStorage[1] = new Flash("Flash", "USB 3.0", 2000);
            RomStorage[2] = new HDD("HDD", "Thunderbolt", 30000);
        }

        
        public double TotalMemoryCalc()
        {
            double totalMemory = 0;
            foreach (var i in RomStorage)
            {
                totalMemory += i.GetFreeMemory();
            }
            return totalMemory;
        }

        public void StorageQty(double dataSize)
        {
            foreach (var i in RomStorage)
            {
                Console.WriteLine();
                i.GetFullInfo();
                Console.WriteLine("=============================");
                Console.WriteLine($"To record {dataSize} Gb of data need: " +
                                  $"{Math.Ceiling(dataSize / i.GetFreeMemory())} units");

            }
        }

        public void TimeToRecord(double dataSize)
        {
            foreach (var i in RomStorage)
            {
                Console.WriteLine();
                i.GetFullInfo();
                Console.WriteLine($"To record {dataSize} Gb of data need: " +
                                  $"{Math.Ceiling(dataSize / i.GetWriteSpeed())} minutes");
            }
        }

    }
}
