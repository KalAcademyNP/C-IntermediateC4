using System;

namespace OperatorOverloadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var box1 = new Box
            {
                Width = 5,
                Height = 10.2,
                Length = 20.5
            };

            var box2 = new Box
            {
                Width = 5,
                Height = 10.2,
                Length = 20.5
            };

            var box3 = box1 + box2;
            Console.WriteLine($"{box3.Length}, {box3.Width}, {box3.Height}");

            var box4 = box1 + 3.45;
            Console.WriteLine(box1 == box2);
            Console.WriteLine(box1.Equals(box2));
        }
    }
}
