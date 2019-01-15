using System;

namespace AutomobileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.Start();
            car.OpenDoor();

            var sc = new SmartCar();
            sc.OpenDoor();

            var car2 = sc as Car;
            car2.OpenDoor();

        }
    }
}
