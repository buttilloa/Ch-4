﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arg, put in ye most treasured numbers up to 999, and no decimals you fuck");
            int total;
            while (true)
            {
                int i = Convert.ToInt32(Console.ReadLine());
                total += i;
                Console.WriteLine(total);
                if (i == 999)
                    break;
            }
        }
    }
}
