using System;

namespace Gislen_Tasks
{
    public class Program {
        public static void Program_Five()
        {
            int number = 100;

            for(int i=1; i<=number; i++)
            {
                if(i%3==0 && i % 5 == 0)
                {
                    Console.WriteLine("Gislen Software");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Gislen");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Spftware");
                }
                else if(i%7==0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Main(String[] args)
        {
            Program_Five();
        }
    }
}