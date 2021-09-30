using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace Inheritance
{
    class Manager:Employee
    {
        public int StockOption { get; set; }

        public Manager() { }
        public Manager(float pay = 0, string name = "", int age = 0, int stockOption = 0):base(pay,name,age)
        {
            StockOption = stockOption;
        }

        public override void GiveBonus(float amount)
        {
            Random rnd = new Random();
            base.GiveBonus(amount);
            StockOption += rnd.Next(500);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine($"Stock Option: {StockOption}");
        }
    }
}
