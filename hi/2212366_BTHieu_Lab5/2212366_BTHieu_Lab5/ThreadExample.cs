using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2212366_BTHieu_Lab5
{
    internal class ThreadExample
    {
        static void Main(string[] args)
        {
            MyThreadClass threadclass1 = new MyThreadClass("Day la tieu trinh thu 1");
            Thread thread1 = new Thread(new ThreadStart(threadclass1.runMyThread));
            thread1.Start();

            MyThreadClass threadclass2 = new MyThreadClass("Day la tieu trinh thu 2");
            Thread thread2 = new Thread(new ThreadStart(threadclass2.runMyThread));
            thread2.Start();

            Console.ReadLine();
        }
    }
   
}
