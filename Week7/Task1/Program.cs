using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread[] thread = new Thread[3];
            thread[0] = new Thread(PrintInfo);
            thread[0].Name = "Thread 1";
            thread[1] = new Thread(PrintInfo);
            thread[1].Name = "Thread 2";
            thread[2] = new Thread(PrintInfo);
            thread[2].Name = "Thread 3";
            for(int i=0;i<3;i++)
            {
                thread[i].Start();
            }
        }
        static void PrintInfo()
        {
            for(int i=0;i<3;i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name);
            }
        }
    }
}
