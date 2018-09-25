using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace WeaponSystems.Vehicles
{
    public class Tank : Vehicle
    {
        public virtual void Shoot()
        {
            Console.WriteLine("The tank goes, \"BOOOM\"");
        }
        public virtual void Reload()
        {
            Console.WriteLine("The tank is is full of rounds.");
        }
        public override void Move()
        {
            Console.WriteLine("Tanks runs on treads ");
        }
        public override void Start()
        {
            Console.WriteLine("You press the mechanical button.");
        }                 
    }
}
