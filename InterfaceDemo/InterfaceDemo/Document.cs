using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    class Document : IStorable
    {
        public void Read()
        {
            Console.WriteLine("Executing document read method");
        }

        public void Write(object obj)
        {
            Console.WriteLine("Executing document write method");
        }

        public void Print()
        {
            Console.WriteLine("Executing document print method");
        }

        public int Status { get; set; }
    }
}
