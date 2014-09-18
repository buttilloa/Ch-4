using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sum50
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, total =0;
            while (i <= 50)
            {
                Console.WriteLine(total);
                 total += i;
                i++;
               
            }
        }
    }
}
