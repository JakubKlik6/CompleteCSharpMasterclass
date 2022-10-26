using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceChallenge
{
    internal class Gun : Weapon, IShootable
    {
        public Gun(string Name): base(Name)
        {
        }
        
        public void Shoot()
        {
            Console.WriteLine("Bang");
        }

    }
}
