using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace WeaponSystems.Vehicles.Aircrafts
{
    public class Plane : Aircraft
    {
        public override void Fly()
        {
            Console.WriteLine("Plane is flying");
        }
        public override void Move()
        {
            Console.WriteLine("Plane is taxiing");
        }
        public override void Start()
        {
            Console.WriteLine("You turn over the props by hand.");
        }
        
    }
}
