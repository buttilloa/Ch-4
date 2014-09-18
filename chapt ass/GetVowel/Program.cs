using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetVowel
{
    class Program
    {
        static void Main(string[] args)
        {
            string type;
            Console.WriteLine("Enter a vowel home boy");
            while (true)
            {
                type = Console.ReadLine();
                if (type == "A" || type == "a" || type == "E" || type == "e" || type == "I" || type == "i" || type == "O" || type == "o" || type == "U" || type == "u")
                {
                    Console.WriteLine("Okie Dokie");
                }
                else if (type == "Y" || type == "y")
                    Console.WriteLine("Only Sometimes dog");
                else
                    Console.WriteLine("NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO");
            }
        }
    }
}
