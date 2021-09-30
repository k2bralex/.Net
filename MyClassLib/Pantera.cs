using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib
{
    public class Pantera : BaseTank
    {
        public Pantera() : base()
        {
            Random r = new Random();
            _tankName = "Pantera";
            _shellQuantity = r.Next(120, 150);
            _armorLevel = r.Next(550, 600);
            _mobilityLevel = r.Next(70, 80); ;
        }

        public int Shell => _shellQuantity;
        public int Armor => _armorLevel;
        public int Mobility => _mobilityLevel;

        public override int Fire()
        {
            Random randomDamage = new Random();
            _shellQuantity--;
            return randomDamage.Next(80, 120);

        }
        public override void Damage(int damage)
        {
            _armorLevel -= damage;
            _mobilityLevel -= (int)(damage * 0.25);
        }

        public override string ShowInfo()
        {
            return $"|{_tankName} | Ammunition: {_shellQuantity} | Armor: {_armorLevel} | Mobility: {_mobilityLevel} |";
        }
          
    }
}
