using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    class FlatFile : IStorable, ICompressible
    {
        public void Compress()
        {
            Console.WriteLine("Executing flatfile compress method");
        }

        public void Decompress()
        {
            Console.WriteLine("Executing flatfile decompress method");
        }

        public void Print()
        {
            Console.WriteLine("Executing flatfile IStorable print method");
        }

        void ICompressible.Print()
        {
            Console.WriteLine("Executing flatfile ICompressible print method");
        }

        public void Read()
        {
            Console.WriteLine("Executing flatfile read method");
        }

        public void Write(object obj)
        {
            Console.WriteLine("Executing flatfile read method");
        }
    }
}
