using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesDemo2
{
    class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 100;

        private bool carIsDead;

        public Car()
        { }
        public Car(int currSpeed, int maxSpeed)
        {
            CurrentSpeed = currSpeed;
            MaxSpeed = maxSpeed;
        }

        //1. Define the delegate type
        //public delegate void CarEngineHandler(string msg);

        //2. Define a member variable of this delegate
        private Action<string> listOfHandlers;


        //3. Add registration function for the caller
        public void RegisterWithCarEngine(Action<string> methodToCall)
        {
            listOfHandlers += methodToCall;
        }

        public void UnRegisterWithCarEngine(Action<string> methodToCall)
        {
            listOfHandlers -= methodToCall;
        }

        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                listOfHandlers?.Invoke("Sorry, the car is dead...");
            } else
            {
                CurrentSpeed += delta;
                //Is the car "almost dead"?
                if (10 == (MaxSpeed-CurrentSpeed) )
                {
                    listOfHandlers?.Invoke("Careful buddy! Gonna blow...");
                }
                if (CurrentSpeed >= MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine($"Currentspeed = {CurrentSpeed}");
            }
        }
    }
}
