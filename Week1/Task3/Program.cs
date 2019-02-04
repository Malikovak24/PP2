using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        public static void Double(string[] s, int n) //создаю метод для дублировния элементов массива
        {
            for(int i=0;i<n;i++)
            {
                Console.Write(s[i] + " " + s[i] + " "); //вывожу каждый элемент дважды 
            }

        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); //создаю переменную и даю значение
            string[] s = Console.ReadLine().Split(); //создаю стринговый массив и разделяю его через пробелы
            Double(s, n); //вызываю метод для дублирования элементов массива    
        }
    }
}
