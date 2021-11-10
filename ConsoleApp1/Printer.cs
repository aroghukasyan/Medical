using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    static class Printer
    {
        public static void Print(IPrintable printable)
        {
            printable.Print();
        }
        //public static void PrintCollection(ICollection<IPrintable> printables)
        public static void PrintCollection(CollectionDoctors printables)
        {
            foreach (var item in printables)
            {
                item.Print();
            }
        }
    }
}
