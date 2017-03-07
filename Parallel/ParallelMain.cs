using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelCode
{
    public class ParallelMain
    {
        private static object _lock = new object();
        private static int Timed_Message(string message, int interval)
        {
            //Parallel for loop
            Parallel.For(0, 10, (i) =>
            {
                lock (_lock)
                {
                    Console.WriteLine($"Message: {message} - Cyclus {i} has an interval of {interval} seconds.");
                    Thread.Sleep(1000 * interval);

                }
            });
            Console.WriteLine($"{message} - Complete");
            return 0;
        }

        static void Main(string[] args)
        {
            int code = 0;
            Console.Write("Give first interval: ");
            string interval1 = Console.ReadLine();
            int interval1_int;
            int.TryParse(interval1, out interval1_int);
            Console.Write("Give second interval: ");
            string interval2 = Console.ReadLine();
            int interval2_int;
            int.TryParse(interval2, out interval2_int);
            Console.Write("Give third interval: ");
            string interval3 = Console.ReadLine();
            int interval3_int;
            int.TryParse(interval3, out interval3_int);
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
            Parallel.ForEach(intervals, value => { lock (_lock) { totalIntervals += value * 10; } });
            Console.WriteLine($"The total lenght of the messages was {totalIntervals} seconds.");
            //PLINQ
            int output = 0;
            output = intervals.AsParallel().Aggregate(
                0, (sub, value) => sub + (value * 10));
            Console.WriteLine($"Or done with PLINQ {output} seconds.");
            Console.ReadLine();
        }

        //to be able to run it from another project
        public string ReturnPath() => Environment.CurrentDirectory;
    }
}
