using System;
using ExtensionMethods.Extensions;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2019, 5, 20, 13, 36, 42);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
