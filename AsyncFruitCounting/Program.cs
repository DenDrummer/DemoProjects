using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncFruitCounting
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DoStuff();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }

            Console.ReadLine();
        }

        private static async void DoStuff()
        {
            int apples = 200;
            int pears = 175;
            Task appleTask = CountApplesAsync(apples);
            Task pearTask = CountPearsAsync(pears);
            await Task.WhenAll(appleTask, pearTask);
            Console.WriteLine($"You should have {apples} apple{(apples == 1 ? "" : "s")} and {pears} pear{(pears == 1 ? "" : "s")}");
        }

        private static Task CountPearsAsync(int pearCount)
        {
            return Task.Run(() =>
            {
                for (int i = 1; i < pearCount; i++)
                {
                    Console.WriteLine($"{i} pear{(i == 1 ? "" : "s")}");
                }
                Console.WriteLine($"All pears have been counted. You have {pearCount} pear{(pearCount == 1 ? "" : "s")}");
            });
        }

        private static Task CountApplesAsync(int appleCount)
        {
            return Task.Run(() =>
            {
                for (int i = 1; i < appleCount; i++)
                {
                    Console.WriteLine($"{i} apple{(i == 1 ? "" : "s")}");
                }
                Console.WriteLine($"All apples have been counted. You have {appleCount} apple{(appleCount == 1 ? "" : "s")}");
            });
        }
    }
}
