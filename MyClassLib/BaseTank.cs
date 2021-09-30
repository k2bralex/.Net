using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace MyClassLib
{
    public abstract class BaseTank : IHasInfo, IWeapon
    {
        protected string _tankName { get; set; } = "NoName";
        protected int _shellQuantity { get; set; } = 0;
        protected int _armorLevel { get; set; } = 0;
        protected int _mobilityLevel { get; set; } = 0;

        public BaseTank() { }

        public BaseTank(string tankName, int shellQuantity, int armorLevel, int mobilityLevel)
        {
            _tankName = tankName;
            _shellQuantity = shellQuantity;
            _armorLevel = armorLevel;
            _mobilityLevel = mobilityLevel;
        }

 

        public abstract int Fire();
        public abstract void Damage(int damage);
        public abstract string ShowInfo();

        public string ShowDamage()
        {
            return $"[{DateTime.Now}] {_tankName} fired with";
        }
        
    }
}
