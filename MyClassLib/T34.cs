using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib
{
    public class T34 : BaseTank
    {
        public T34():base()
        {
            Random r = new Random();
            _tankName = "T-34";
            _shellQuantity = r.Next(90,100);
            _armorLevel = r.Next(450, 500);
            _mobilityLevel = r.Next(90, 100); ;
        }

        public int Shell => _shellQuantity;
        public int Armor => _armorLevel;
        public int Mobility => _mobilityLevel;


        public override int Fire()
        {
            Random randomDamage = new Random();
            _shellQuantity--;
            return randomDamage.Next(50, 100);
        }

        public override void Damage(int damage)
        {
            _armorLevel -= damage;
            _mobilityLevel -= (int)(damage * 0.2);
        }

        public override string ShowInfo()
        {
            return $"|{_tankName} | Ammunition: {_shellQuantity} | Armor: {_armorLevel} | Mobility: {_mobilityLevel} |";
        }

        
    }
}
