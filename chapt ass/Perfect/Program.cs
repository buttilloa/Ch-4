using System;

namespace Perfect
{
    class Program
    {
       
        static void Main(string[] args)
        {
              int Perf = 0,loop =1, total = 0;
            while (Perf<=500)
            {
                while (loop <= Perf)
                {
                   
                    if (Perf % loop == 0)
                     total += loop;

                    if (total == Perf)
                    {
                        Console.WriteLine(total);
                       
                        //break;
                    }
                    
                    loop++;
                }
                loop = 1; 
                total = 0;
               Perf++;
           }
        }
       
    }
}
