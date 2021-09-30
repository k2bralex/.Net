using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    abstract class Employee
    {
        private const string WARNING_NAME_FIELD_OVERFLOW = "Error! Name lenght exceed 15 characters!";

        private string emplName;
        private int empID;
        private float currPay;
        private static int countEMPL = 0;
        private int empAge;

        public Employee()
        {
            countEMPL++;
            empID = countEMPL;
        }

        // !!!!!!use methotds in costructor!!!!!!
        public Employee(float pay = 0, string name="", int age = 0) : this()
        {
            Name = name;
            Pay = pay;
            Age=age;
        }

        public string Name
        {
            get { return emplName; }
            set {
                if (value.Length>15)
                {
                    Console.WriteLine(WARNING_NAME_FIELD_OVERFLOW);
                }
                else
                {
                    emplName = value;
                }
            }
        }

        public float Pay { get; set; }
        public int Age { get; set; }

        public virtual void GiveBonus(float amount)
        {
            currPay += amount;
        }

        public virtual void DisplayStats()
        {
            Console.WriteLine($"TOTAL EMPLOYEE: {countEMPL}");
            Console.WriteLine($"Name: {emplName}");
            Console.WriteLine($"Age: {empAge}");
            Console.WriteLine($"ID: {empID}");
            Console.WriteLine($"Pay: {currPay}");
        }
    }
}
