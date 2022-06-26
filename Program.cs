using System;
using System.Collections.Generic;

namespace temp
{

    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(Console.ReadLine().Count(x => char.IsDigit(x)));
        }

    }
}