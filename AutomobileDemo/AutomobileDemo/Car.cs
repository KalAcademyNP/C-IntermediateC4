using System;
using System.Collections.Generic;
using System.Text;

namespace AutomobileDemo
{
    class Car : Automobile
    {
        public override void OpenDoor()
        {
            Console.WriteLine("Car open door");
        }
    }
}
