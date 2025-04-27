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

        public static void Program_Seven()
        {
            int n = 5;

            Console.WriteLine("Enter the Give Integer Array Element : ");
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int total = 0;
            Console.WriteLine("Reverse of Array");
            for (int i = n - 1; i >= 0; i--)
            {
                total += arr[i];
                Console.Write(arr[i] + " ");
            }

            //int ii = 0;
            //int j = arr.Length-1;
            //while (ii < j)
            //{
            //    arr[ii] ^= arr[j];
            //    arr[j] ^= arr[ii];
            //    arr[ii] ^= arr[j];

            //    ii++;
            //    j--;
            //}

            foreach (int num in arr)
            {
                Console.WriteLine(num+" ");
            }
            Console.WriteLine();

            Console.Write("Average: ");
            Console.WriteLine(total / n);

        }

        public static void Program_One()
        {
            Con
        }
        static void Main(String[] args)
        {
            //Program_Five();
            //Program_Seven();
            Program_One();
            Console.ReadKey();
        }
    }
}