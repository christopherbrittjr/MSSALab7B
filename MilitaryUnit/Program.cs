using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WeaponSystems;
using WeaponSystems.Vehicles;
using WeaponSystems.Vehicles.Aircrafts;


namespace MilitaryUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            Aircraft a10 = new Plane();
            Plane f22 = new Plane();
            Aircraft hh60 = new Helicopter();
            Helicopter ah64 = new Helicopter();

            Tank m1 = new Tank();
            Vehicle tank = new Tank();
            Firearm M1911 = new Firearm();

            M1911.Shoot();
            m1.Shoot();

            a10.Fly();
            f22.Move();
            ah64.Move();
            ah64.Maintain();
            tank.Fuel();

        }
    }
}
