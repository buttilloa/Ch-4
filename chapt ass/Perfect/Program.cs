using System;

namespace Perfect
{
    class Program
    {
       
        static void Main(string[] args)
        {
              int Perf = 1,loop =1, total = 0;
            while (Perf<=500)
            {
                while (loop <= Perf)
                {
                    if (Perf % loop == 0)
                     total += loop; 
                    
                    if (total == Perf)
                    Console.WriteLine(total);
                    //Console.WriteLine(loop);
                    loop++;
                }
                loop = 1;
               Perf++;
           }
        }
       
    }
}
