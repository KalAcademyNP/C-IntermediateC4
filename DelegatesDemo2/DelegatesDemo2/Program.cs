using System;

namespace DelegatesDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Create the delegate
            var n1 = new Func<int, int>(Calculator.AddNum);
            Console.WriteLine(n1(20));

            //var n2 = new NumberChanger(Square);
            //Console.WriteLine(n2(34));


            var c1 = new Car(10, 100);
            c1.RegisterWithCarEngine(OnCarEngineEvent);
            c1.RegisterWithCarEngine(OnCarEngineEvent2);
            for (var i = 0; i < 6; i++)
                c1.Accelerate(20);

            c1.UnRegisterWithCarEngine(OnCarEngineEvent2);
            for (var i = 0; i < 6; i++)
                c1.Accelerate(20);

        }

        //static int Square(int num) => num * num;

        public static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("**********Message from the car***********");
            Console.WriteLine(msg);
            Console.WriteLine("******************************************");
        }

        public static void OnCarEngineEvent2(string msg)
        {
            Console.WriteLine(msg.ToUpper());
        }
    }
}
