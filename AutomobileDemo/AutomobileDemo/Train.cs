using System;
using System.Collections.Generic;
using System.Text;

namespace AutomobileDemo
{
    class Train : Automobile
    {
        public override void OpenDoor()
        {
            Console.WriteLine("Train open door");
        }
    }
}
