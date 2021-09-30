using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace Inheritance
{
    class SalsePerson:Employee
    {
        public int SalesNumber { get; set; }

        public SalsePerson() { }

        public SalsePerson(float pay = 0, string name = "", int age = 0, int salesNumber = 0) : base(pay, name, age)
        {
            SalesNumber = salesNumber;
        }

        public override void GiveBonus(float amount)
        {
            int salesBonus = 0;
            if (SalesNumber > 10 && SalesNumber <= 100)
            {
                salesBonus = 10;
            }
            else
            {
                if (SalesNumber>100&&SalesNumber<=200)
                {
                    salesBonus = 15;
                }
                else
                {
                    salesBonus = 20;

                }
                base.GiveBonus(amount*salesBonus);
            }
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine($"Sales Number: {SalesNumber}");
        }

        public override string ToString()
        {
            return $"[Employee Name: {base.Name}, Sales number: {SalesNumber}]";
        }
    }
}
