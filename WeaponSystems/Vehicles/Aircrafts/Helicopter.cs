using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace WeaponSystems.Vehicles.Aircrafts
{
    public class Helicopter : Aircraft
    {
        public override void Fly()
        {
            Console.WriteLine("Whoppa whoppa whoppa whoppa");
        }       
        
        public override void Start()
        {
            Console.WriteLine("Helicopter turbines spin up.");
        }      
        public override void Maintain()
        {
            Console.WriteLine("Helicopter is all over the hanger floor.");
        }
    }
}

