using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace WeaponSystems.Vehicles
{
    public class Aircraft : Vehicle
    {
        public virtual void Fly()
        {
            Console.WriteLine("Aircraft is flying");
        }
        public override void Move()
        {
            Fly();
        }
        public override void Start()
        {
            Console.WriteLine("Aircraft engines spin up.");
        }
        public override void Fuel()
        {
            Console.WriteLine("Aircraft filled up with JP-8.");
        }
        public override void Maintain()
        {
            Console.WriteLine("Aircraft is down for 6 months at the intermediate maintenance center.");
        }
    }
}

