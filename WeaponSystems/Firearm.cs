using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace WeaponSystems
{
    public class Firearm
    {
        public virtual void Shoot()
        {
            Console.WriteLine("Pew Pew");
        }
        public virtual void Clean()
        {
            Console.WriteLine("Firearm is clean enough to eat.");
        }
        public virtual void Reload()
        {
            Console.WriteLine("Weapon is reloaded.");
        }
    }
}
