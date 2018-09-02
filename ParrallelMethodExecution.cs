using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;


namespace ConsoleApp1
{
    class ParrallelMethodExecution
    {
        static void Main(string[] args)
        {
            Stopwatch a = new Stopwatch();
            Task obj = new Task(Run);
            Task obj1 = new Task(Stop);

            a.Start();
            obj.Start();
            obj1.Start();
            Thread.Sleep(10000);
            a.Stop();
            Console.WriteLine("Time elapsed: {0}", a.Elapsed);
            Console.Read();
        }
        public static void Run()
        {
            Console.WriteLine("Run Fast");
            Thread.Sleep(5000);
            Console.WriteLine("Run Again");
        }
        public static void Stop()
        {
            Console.WriteLine("Stop running");
            Thread.Sleep(6000);
            Console.WriteLine("Start Running again");
        }
    }

    class StopWatchProgram
    {
        static void Main()
        {
            // Create new stopwatch.
            Stopwatch stopwatch = new Stopwatch();

            // Begin timing.
            stopwatch.Start();

            // Do something.
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1);
            }

            // Stop timing.
            stopwatch.Stop();

            // Write result.
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
            Console.Read();
        }
    }
}
