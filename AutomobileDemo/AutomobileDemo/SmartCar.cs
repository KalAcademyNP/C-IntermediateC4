using System;
using System.Collections.Generic;
using System.Text;

namespace AutomobileDemo
{
    class SmartCar : Car
    {
        public override void OpenDoor()
        {
            Console.WriteLine("Smart car open door");
        }
    }
}
