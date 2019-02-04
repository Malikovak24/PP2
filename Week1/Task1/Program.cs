using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); // ввод числа и конвертирование ее в тип integer
            int[] a = new int[n]; //создание массива с элементами числового значения
            int[] res = new int[n]; //создание второго массива
            string[] s = Console.ReadLine().Split(); //создание массива с элементами типа стринга и разделение их через пробелы
            int cnt = 0; //создание переменной счетчика
            bool prime = true;  //создание переменной булевого типа
            for(int i=0;i<n;++i) //создание цикла
            {
                prime = true; 
                a[i] = Convert.ToInt32(s[i]); //конвертирую элемент стрингового массива и сохраняю как элемент массива типа integer
                if (a[i] == 1) // если элемент равен одному пропустить его
                    continue;
                for (int j = 2; j < a[i]; ++j) // создание второго цикла
                {

                    if (a[i] % j == 0) // проверка на prime number
                        prime = false; // если число делится на предыдущие на него числа, начиная от 2, то это число не прайм
                }
                    if (prime == true) // в противном случае мы записываем prime number как элемент нового массива 
                    {
                        res[cnt] = a[i];
                        cnt++; 
                    }

                }
   
            Console.WriteLine(cnt); //выводим количество простых чисел
            for(int i=0;i<cnt;++i)
            {
                Console.Write(res[i] + " "); //выводим на консоль эти простые числа через пробел в одной строке
            }

        }
    }
}
