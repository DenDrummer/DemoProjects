using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//Event-based Asynchronous Pattern
//not recommended 
//can be implemented in different ways but depends on the following
//=>methods should be executed asynchronously
//raise an event once the execution has come to an end
namespace EAP
{
    class Program
    {
        //delegate will execute main method asynchronously
        private delegate void GetWorkerEvenNumbersHandler(int min, int max, AsyncOperation ayncOp);
        private delegate void GetWorkerOddNumbersHandler(int min, int max, AsyncOperation asyncOp);

        //This delegate raise the event post compelting the async operation
        private static SendOrPostCallback onCompletedDelegate_Even;
        private static SendOrPostCallback onCompetedDelegate_Odd;

        //To allow async method to call multiple time,
        //Store the tasks in the list
        //Send proper value back to main thread
        private static HybridDictionary tasks = new HybridDictionary();

        //Event
        //can be designed the way you want
        //should just deliver the value of the result 
        //Will be captured by the main thread     
        public event GetEvenNumbersHandler GetEvenNumbers_Completed;
        public event GetOddNumbersHandler GetOddNumbers_Completed;

        static void Main(string[] args)
        {
            Program pr = new Program();
            Console.Write("Give min: ");
            string minInput = Console.ReadLine();
            Console.Write("Give max: ");
            string maxInput = Console.ReadLine();
            int min;
            int max;
            int.TryParse(minInput, out min);
            int.TryParse(maxInput, out max);
            GetEvenNumbersAsync(min, max, 5);
            GetOddNumbersAsync(min, max, 6);
            Console.ReadLine();

        }

        public Program()
        {
            Console.WriteLine("Welcome to the most fantastic thing on earth!");
            Console.WriteLine("Well if you don't count C#, sleeping, woman, World of Warcraft, Seppe De Meester, pizza, Monster and Life is Strange as the most fantastic things on earth.");
            onCompletedDelegate_Even = new SendOrPostCallback(CompletedDelegateFunc_Even);
            onCompetedDelegate_Odd = new SendOrPostCallback(CompletedDelegateFunc_Odd);
        }

        //Called by SnedOrPostCallback
        //raise GetEvenNumbers_Completed
        private void CompletedDelegateFunc_Even(object operationState)
        {
            GetEvenNumberEventArgs arg = operationState as GetEvenNumberEventArgs;

            //Checks if GetEvenNumbers_Completed is empty (but then shortend notation)
            GetEvenNumbers_Completed?.Invoke(this, arg);
        }

        private void CompletedDelegateFunc_Odd(object operationState)
        {
            GetOddNumbersArgs arg = operationState as GetOddNumbersArgs;
            //Executes a delegate on the thread that owns the control's underlying window handle
            GetOddNumbers_Completed?.Invoke(this, arg);
        }

        #region Even
        //Synchronous version of the method
        public void GetEvenNumbers(int min, int max)
        {
            for (int i = min; i <= max; i++)
            {
                Thread.Sleep(3000);
                if (i % 2 == 0)
                {
                    Console.Write("{0} is even!\n", i);
                }
            }

            Console.WriteLine("Done with the evens!");
        }

        //Async version of the method
        public static void GetEvenNumbersAsync(int min, int max, object userState)
        {
            //Tracks the lifetime of an asynchronous operation
            //Manager => provides asynchronous operations for the AsyncController class
            AsyncOperation asyncOp = AsyncOperationManager.CreateOperation(userState);

            //Multiple threats will acces the task dictionary
            //must be locked to serialize acces
            lock (tasks.SyncRoot)
            {
                if (tasks.Contains(userState))
                {
                    throw new ArgumentException("The userState parameter must be unique!");
                }

                tasks[userState] = asyncOp;
            }

            GetWorkerEvenNumbersHandler evenHandler = new GetWorkerEvenNumbersHandler(EvenNumbersWorker);

            //Execute process Asynchronously
            evenHandler.BeginInvoke(min, max, asyncOp, null, null);

        }

        //Does the actual work
        private static void EvenNumbersWorker(int min, int max, AsyncOperation asyncOp)
        {
            for (int i = min; i <= max; i++)
            {
                Thread.Sleep(3000);
                if (i % 2 == 0)
                {
                    Console.Write("{0} is even!\n", i);
                }
            }

            Console.WriteLine("Done with the evens!");
            //SyncRoot gets an object that can be used to 
            //synchronize acces to the HybridDictionary
            lock (tasks.SyncRoot)
            {
                //UserSuppliedState gets or sets an object used to uniquely
                //identify an async operation
                tasks.Remove(asyncOp.UserSuppliedState);
            }

            GetEvenNumberEventArgs arg = new GetEvenNumberEventArgs(null, false, asyncOp.UserSuppliedState);
            asyncOp.PostOperationCompleted(onCompletedDelegate_Even, arg);
        }
        #endregion

        #region Odd
        public void GetOddNumbers(int min, int max)
        {
            for (int i = min; i <= max; i++)
            {
                Thread.Sleep(3000);
                if (i % 2 != 0)
                {
                    Console.Write("{0} is odd!\n", i);
                }
            }

            Console.WriteLine("Done! with the odds!");
        }

        public static void GetOddNumbersAsync(int min, int max, object userState)
        {
            AsyncOperation asyncOp = AsyncOperationManager.CreateOperation(userState);

            lock (tasks.SyncRoot)
            {
                if (tasks.Contains(userState))
                {
                    throw new ArgumentException("The userState parameter must be unique!");
                }

                tasks[userState] = asyncOp;
            }

            GetWorkerOddNumbersHandler oddHandler = new GetWorkerOddNumbersHandler(OddNumbersWorker);

            oddHandler.BeginInvoke(min, max, asyncOp, null, null);
        }

        private static void OddNumbersWorker(int min, int max, AsyncOperation asyncOp)
        {
            for (int i = min; i <= max; i++)
            {
                Thread.Sleep(3000);
                if (i % 2 != 0)
                {
                    Console.Write("{0} is odd!\n", i);
                }
            }

            Console.WriteLine("Done with the odds!");

            lock (tasks.SyncRoot)
            {
                tasks.Remove(asyncOp.UserSuppliedState);
            }

            GetOddNumbersArgs arg = new GetOddNumbersArgs(null, false, asyncOp.UserSuppliedState);
            asyncOp.PostOperationCompleted(onCompetedDelegate_Odd, arg);
        }
        #endregion
    }
}
