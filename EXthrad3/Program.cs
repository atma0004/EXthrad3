using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EX05_Threads_1
    {
    class Program
        {
        static void Main(string[] args)
            {
            Thread firstThread = new Thread(new ThreadStart(FirstThread));
            Thread secondThread = new Thread(new ThreadStart(SecondThread));
            firstThread.Start();
            secondThread.Start();

            }
        static void FirstThread()
            {

            for (int i = 0; i<5; i++)
                {
                Console.WriteLine("C# thread is easy");
                Thread.Sleep(1000);

                }
            Console.ReadKey();
            }
        static void SecondThread()
            {

            for (int i = 0; i<5; i++)
                {
                Console.WriteLine("Also, with multiple threads ");
                Thread.Sleep(1000);

                }
            }
        }
    }
