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
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------ Grovery Bill Calculator ------------------");
            Console.WriteLine("||     ||    ||     ||    ||     ||     ||    ||     ||    ||");                                                        
            Console.WriteLine("-------------------------------------------------------------");
            Console.ResetColor();

            Console.WriteLine("              Choose the Items for purchasing                ");
            Console.WriteLine("               1. Milk              - Rs.20                  ");
            Console.WriteLine("               2. Coconut Oil       - Rs.50                  ");
            Console.WriteLine("               3. Sugar             - Rs.15                  ");
            Console.WriteLine("               4. Salt              - Rs.20                  ");
            Console.WriteLine("               5. Rice              - Rs.50                  ");
            Console.WriteLine("               6. Butter            - Rs.30                  ");

            Console.WriteLine("                    For Billing Press '#'                    ");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine("-------------------------------------------------------------");
            Console.ResetColor();

            Dictionary<string, int> items = new Dictionary<string, int>()
            {
                {"milk", 20},
                {"coconut oil", 50},
                {"sugar", 15 },
                {"salt",20},
                {"rice", 50},
                {"butter", 30}
            };

            int quantity = 0;
            int total = 0;

            

            Dictionary<string, int> purchasedItems = new Dictionary<string, int>();

            while (true)
            {
                string userInput = Console.ReadLine().ToLower();
                if(userInput == "#")
                {
                    break;
                }
                switch (userInput)
                {
                    case "milk":
                        quantity += 1;
                        total += items[userInput];
                        purchasedItems.Add(userInput, items[userInput]);
                        break;

                    case "coconut oil":
                        quantity += 1;
                        total += items[userInput];
                        purchasedItems.Add(userInput, items[userInput]);
                        break;

                    case "sugar":
                        quantity += 1;
                        total += items[userInput];
                        purchasedItems.Add(userInput, items[userInput]);
                        break;

                    case "salt":
                        quantity += 1;
                        total += items[userInput];
                        purchasedItems.Add(userInput, items[userInput]);
                        break;

                    case "rice":
                        quantity += 1;
                        total += items[userInput];
                        purchasedItems.Add(userInput, items[userInput]);
                        break;

                    case "butter":
                        quantity += 1;
                        total += items[userInput];
                        purchasedItems.Add(userInput, items[userInput]);
                        break;

                    default:
                        Console.WriteLine("Items Not Found");
                        break;
                }
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine("-------------------------------------------------------------");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your Purchased Items: ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            foreach (KeyValuePair<string,int> i in purchasedItems)
            {
                Console.WriteLine(i.Key +" - "+i.Value);
            }
            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-------------------- Total Quantity - " + quantity +" ---------------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("------------------- Total Amount - " + total +" -----------------------");
            Console.ResetColor();

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