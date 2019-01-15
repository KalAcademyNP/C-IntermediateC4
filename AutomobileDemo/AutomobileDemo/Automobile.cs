using System;
using System.Collections.Generic;
using System.Text;

namespace AutomobileDemo
{
    abstract class Automobile : IAutomobile
    {
        public abstract void OpenDoor();

        public void Start()
        {
            Console.WriteLine("Abstract implementation of start");
        }

        public void Stop()
        {
            Console.WriteLine("Abstract implementation of stop");
        }
    }
}
