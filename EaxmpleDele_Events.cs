using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class EaxmpleDele_Events
    {
        public delegate void RunDelegate();
        public delegate void StopDelegate();
        static void Main(string[] args)
        {
            RunDelegate r1 = new RunDelegate(Run);
            StopDelegate s1 = new StopDelegate(Stop);
            r1();
            s1();
            Console.Read();          
        }
       public static void Run()
        {
            Console.WriteLine("Start Running");
        }
        static void Stop()
        {
            Console.WriteLine("Stop Running");
        }
    }
}
