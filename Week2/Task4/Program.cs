using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo fs = new FileInfo(@"C:\Users\Asus\source\repos\Week2\Task4\Text1.txt");
            string path = @"C:\Users\Asus\source\repos\Week2\Text1.txt";
            fs.CopyTo(path, true);
            fs.Delete();
        }
    }
}
