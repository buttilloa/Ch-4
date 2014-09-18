using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 3; i++)
            {
                Console.Write(i + " ");
                for (int j = 1; j <= 3; j++)
                {
                    if (i > 0) 
                        Console.Write(i * j + " ");
                    else 
                        Console.Write(j + " ");
                }
                Console.Write("\n");
            }


        }
    }
}
