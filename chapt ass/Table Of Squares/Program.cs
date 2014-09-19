using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Table_Of_Squares
{
    class Program
    {
        static void Main(string[] args)
        {
            int Squares = 1;
            while (Squares <=20)
            {
                Console.Write(Squares);
                Console.WriteLine(" " + Squares * Squares);
                Squares++;

            }
        }
    }
}
