using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelCode
{
    class ParallelMain
    {
        private static int Timed_Message(string message, int interval)
        {          
            //Parallel for loop
            Parallel.For(0, 10, (i) =>
            {
                Console.WriteLine("Message: {0} - Cyclus {1} has an interval of {2} seconds.", message, i, interval);
                Thread.Sleep(1000 * interval);

            });
            Console.WriteLine("{0} - Complete", message);
            return 0;
        }

        static void Main(string[] args)
        {
            int code = 0;
            Console.Write("Give first interval: ");
            string interval1 = Console.ReadLine();
            int interval1_int;
            Int32.TryParse(interval1, out interval1_int);
            Console.Write("Give second interval: ");
            string interval2 = Console.ReadLine();
            int interval2_int;
            Int32.TryParse(interval2, out interval2_int);
            Console.Write("Give third interval: ");
            string interval3 = Console.ReadLine();
            int interval3_int;
            Int32.TryParse(interval3, out interval3_int);
            int[] intervals = { interval1_int, interval2_int, interval3_int };
            Task task = new Task(() => code = Timed_Message("Eten", interval1_int));
            task.Start();
            Task otherTask = new Task(() => code = Timed_Message("Slapen", interval2_int));
            otherTask.Start();
            Timed_Message("Tv_kijken", interval3_int);

            //wait for input before exiting
            Console.WriteLine("Press [ENTER] after all the messages are complete.");
            Console.ReadLine();
            int totalIntervals = 0;
            //Parallel foreach
            Parallel.ForEach(intervals, value => { totalIntervals += value * 10;  });
            Console.WriteLine("The total lenght of the messages was {0} seconds.", totalIntervals);
            //PLINQ
            int output = 0;
            output = intervals.AsParallel().Aggregate<int, int>(
                0, (sub, value) => sub + (value * 10));
            Console.WriteLine("Or done with PLINQ {0} seconds.", output);
            Console.ReadLine();
        }
    }
}
