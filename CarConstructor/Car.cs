using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConstructor
{
    //делегат на добавление частей машины
    delegate string CarPart();

    //делегат для чтения
    delegate void AnyPart();

    class Car
    {
        //коллекция частей из которых состоит машина
        private List<Part> partList { get; set; } = new List<Part>();

        public CarPart carPart;

        public AnyPart anyPart;

        public Car()
        {
            
        }
        //добавление запчасти в коллекцию
        public void AddPart()
        {
            Part newPart = new Part(carPart?.Invoke());
            partList.Add(newPart);
        }

        public IEnumerable<Part> ReadAll()
        {
            anyPart?.Invoke();
            return partList;
        }
    }
}
