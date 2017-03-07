 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Not recommend anymore => outdated but very simple + practical
//Asynchronous Programming Model
namespace APM
{
    public class Program
    {
        private delegate int GetCountEvenNumbersHandler(int min, int max);
        private static GetCountEvenNumbersHandler getCountEvenNumbersCaller;
        private delegate int GetCountOddNumbersHandler(int min, int max);
        private static GetCountOddNumbersHandler getCountOddNumbersCaller;

        static void Main(string[] args)
        {
            Console.WriteLine("There are " + EndCountEvenNumbers(BeginCountEvenNumbers(1, 10, null, null)) + " even numbers between 1 and 10.");
            Console.WriteLine("There are " + EndCountOddNumbers(BeginCountOddNumbers(1,10,null,null)) + " odd numbers between 1 and 10.");
            Console.ReadLine();
        }

        public static int CountEvenNumbers(int min, int max)
        {
           
            //Provides a set of methods for querying that implements
            //ParallelQuery(TSource)
            return ParallelEnumerable.Range(min, max).Count(n => n % 2 == 0);
        }

        public static int CountOddNumbers(int min, int max)
        {
            return ParallelEnumerable.Range(min, max).Count(n => n % 2 != 0);
        }

        //IAsyncResult represents the status of an asynchronous operation
        //Objects of this type store information about an
        //asynchronous operation.
        //This method begins the asynchronous operation
        //AsyncCallBack Delegat references a method to be called
        //when a corresponding asyncronous operation completes (not needed here)
        public static IAsyncResult BeginCountEvenNumbers(int min, int max, AsyncCallback callback, object userState)
        {
            getCountEvenNumbersCaller = CountEvenNumbers;
            //Executes the specified delegate asynchronously with the specified arguments
            //on the thread that the control's underlying handle was
            //created on.
            return getCountEvenNumbersCaller.BeginInvoke(min, max, callback, userState);
        }

        public static IAsyncResult BeginCountOddNumbers(int min, int max, AsyncCallback callback, object userState)
        {
            getCountOddNumbersCaller = CountOddNumbers;
            return getCountOddNumbersCaller.BeginInvoke(min, max, callback, userState);
        }

        //This method ends the asyncrhonous operation
        public static int EndCountEvenNumbers(IAsyncResult result)
        {
            return getCountEvenNumbersCaller.EndInvoke(result);
        }

        public static int EndCountOddNumbers(IAsyncResult result)
        {
            //returns the return value of the asynchronous operation
            //represented by the IAsyncResult passed
            return getCountOddNumbersCaller.EndInvoke(result);
        }

        //to be able to run it from another project
        public string ReturnPath() => Environment.CurrentDirectory;
    }
}
