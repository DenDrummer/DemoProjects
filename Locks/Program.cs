using System;
using System.Threading;

namespace Locks
{
    public class Program
    {
        private static object _lock = new Object();
        private static object _lock2 = new Object();
        static void Main(string[] args)
        {
            MenuAction();
        }

        private static void MenuAction()
        {
            bool done = false;
            while (!done)
            {


                Console.WriteLine("1) Lock");
                Console.WriteLine("2) DeadLock");
                Console.WriteLine("0) Stop");
                Console.Write("Choice => ");
                string choice = Console.ReadLine();
                int choice_int;
                if (int.TryParse(choice, out choice_int))
                {
                    switch (choice_int)
                    {
                        case 1: Lock(); break;
                        case 2: DeadLock(); break;
                        case 0: Console.WriteLine("Bye!"); done = true; break;
                        default: Console.WriteLine("You shouldn't be here!"); break;
                    }
                }
                else
                {
                    Console.WriteLine("Please type a number!");
                }
            }
        }

        private static void Lock()
        {
            Console.Write("Give balance: ");
            string balance = Console.ReadLine();
            int balance_int;
            Console.Write("Give amount: ");
            string ammount = Console.ReadLine();
            int ammount_int;
            if (int.TryParse(balance, out balance_int) && int.TryParse(ammount, out ammount_int))
            {
                LockSomething(ammount_int, balance_int);
            }
            else
            {
                Console.WriteLine("A number isn't to hard to give, right?");
            }
        }

        private static void LockSomething(int ammount, int balance)
        {

            if (balance < 0)
            {
                Console.WriteLine("Negative balance isn't allowed!");
            }

            lock (_lock)
            {
                if (balance >= ammount)
                {
                    Console.WriteLine($"Balance before withdrawing money: {balance}");
                    Console.WriteLine($"Ammount: {ammount}");
                    balance -= ammount;
                    Console.WriteLine($"Balance after withdrawing money: {balance}");
                }
            }
        }

        private static void DeadLock()
        {
            Console.WriteLine("Dangerous road ahead!!");
            Console.Write("Go for it? (y/n) ");
            char input = (char)Console.Read();
            if (input.Equals('y'))
            {
                Thread t1 = new Thread(startLocking);
                t1.Start();
                lock (_lock)
                {
                    Console.WriteLine("Main has _lock");
                    Thread.Sleep(1000);
                    lock (_lock2)
                    {
                        Console.WriteLine("Main has also _lock2");
                    }
                }
            }
            else if (input.Equals('n'))
            {
                return;
            }
            else
            {
                Console.WriteLine("You could've just answered with 'n' for no!");
            }
        }

        private static void startLocking()
        {
            lock (_lock2)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} had _lock2");
                Thread.Sleep(1000);
                lock (_lock)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name} has also _lock");
                }
            }
        }

        //to be able to run it from another project
        public string ReturnPath() => Environment.CurrentDirectory;
    }
}
