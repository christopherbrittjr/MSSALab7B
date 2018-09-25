using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace WeaponSystems
{
    public class Vehicle
    {
        public virtual void Move()
        {
            Console.WriteLine("Vehicle moved.");
        }
        public virtual void Start()
        {
            Console.WriteLine("You shorted the starter with a wrench.");
        }
        public virtual void Fuel()
        {
            Console.WriteLine("Vehicle is full of fuel.");
        }
        public virtual void Maintain()
        {
            Console.WriteLine("Vehicle is down for maintenance.");
        }
    }
}
