using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Locks
{
    class Program
    {
        private static Object _lock = new Object();
        private static Object _lock2 = new Object();
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
                if (Int32.TryParse(choice, out choice_int))
                {
                    switch (choice_int)
                    {
                        case 1:
                            Console.Write("Give balance: ");
                            string balance = Console.ReadLine();
                            int balance_int;
                            Console.Write("Give amount: ");
                            string amount = Console.ReadLine();
                            int amount_int;
                            if(Int32.TryParse(balance, out balance_int) && Int32.TryParse(amount, out amount_int))
                            {
                                LockSomething(amount_int, balance_int);
                            }else
                            {
                                Console.WriteLine("A number isn't to hard to give, right?");
                            }
                            
                            break;
                        case 2: DeadLock(); break;
                        case 0: Console.WriteLine("Bye!"); done = true; break;
                        default: Console.WriteLine("You shouldn't be here!"); break;
                    }
                }else
                {
                    Console.WriteLine("Please type a number!");
                }
            }
        }

        private static void LockSomething(int amount, int balance)
        {

           if(balance < 0)
            {
                Console.WriteLine("Negative balance isn't allowed!");
            }

            lock (_lock)
            {
                if(balance >= amount)
                {
                    Console.WriteLine("Balance before withdrawing money: {0}", balance);
                    Console.WriteLine("Amount: {0}", amount);
                    balance -= amount;
                    Console.WriteLine("Balance after withdrawing money: {0}", balance);
                }
            }
        }

        private static void DeadLock()
        {
            Console.Write("Dangerous road ahead!!\nGo for it?(y/n) ");
            if (Console.Read().Equals('n'))
            {
                return;

            }
                Thread t1 = new Thread(startLocking);
                t1.Start();
                lock (_lock) {
                    Console.WriteLine("Main has _lock");
                    Thread.Sleep(1000);
                    lock (_lock2)
                    {
                        Console.WriteLine("Main has also _lock2");
                    }
                }
            }

        private static void startLocking()
        {
            lock (_lock2)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " had _lock2");
                Thread.Sleep(1000);
                lock (_lock)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " has also _lock");
                }
            }
        }
    }
}
