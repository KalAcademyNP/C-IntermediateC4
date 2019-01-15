using System;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var docStorage = new Document();
            //Print(docStorage);

            var fileStorage = new FlatFile();
            //Print(fileStorage);
            fileStorage.Print();

            var compressStorage = fileStorage as ICompressible;
            compressStorage.Print();

            //IStorable dummyStorage = docStorage;
            //if (dummyStorage is FlatFile)
            //{
            //    var dummy2 = (FlatFile)dummyStorage;
            //    Print(dummy2);

            //}

            //var dummy3 = dummyStorage as FlatFile;
            //if (dummy3 != null)
            //{
            //    Print(dummy3);
            //}

        }

        static void Print(IStorable store)
        {
            store.Read();
        }
    }
}
