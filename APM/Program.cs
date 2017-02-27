using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Not recommend anymore => outdated but very simple + practical
//Asynchronous Programming Model
namespace APM
{
    class Program
    {
        private delegate int GetCountEvenNumbersHandler(int min, int count);
        private static GetCountEvenNumbersHandler getCountEvenNumbersCaller;

        static void Main(string[] args)
        {
            Console.WriteLine(EndCountEvenNumbers(BeginCountEvenNumbers(1, 10, null, null))); 
            Console.ReadLine();
        }

        public static int CountEvenNumbers(int min, int count)
        {
            //PrintCurrentThreadId("GetPrimeCount");
            //Provides a set of methods for querying that implements
            //ParallelQuery(TSource)
            return ParallelEnumerable.Range(min, count).Count(n => n % 2 == 0);
        }

        //IAsyncResult represents the status of an asynchronous operation
        //Objects of this type store information about an
        //asynchronous operation.
        //This method begins the asynchronous operation
        //AsyncCallBack Delegat references a method to be called
        //when a corresponding asyncronous operation completes (not needed here)
        public static IAsyncResult BeginCountEvenNumbers(int min, int count, AsyncCallback callback, object userState)
        {
            getCountEvenNumbersCaller = CountEvenNumbers;
            return getCountEvenNumbersCaller.BeginInvoke(min, count, callback, userState);
        }

        //This method ends the asyncrhonous operation
        public static int EndCountEvenNumbers(IAsyncResult result)
        {
            return getCountEvenNumbersCaller.EndInvoke(result);
        }
    }
}
