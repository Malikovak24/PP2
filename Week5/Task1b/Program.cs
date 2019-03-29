using System;
using System.Collections.Generic;
using System.IO; //подключаем нужные библиотеки
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task1b
{
    public class Complex //создаем класс Complex
    {
        public double a; //создаем переменные типа double a,b
        public double b;
        XmlSerializer xms = new XmlSerializer(typeof(Complex)); //передаем в конструктор тип класса
        string text = "Complex.txt";
        public override string ToString()
        {
            return string.Format("{0}+{1}i", a, b);

        }
        public void Serialize() //создаем метод сериализации
        {
            using (FileStream fs = new FileStream(text, FileMode.Create, FileAccess.Write)) //получаем поток, куда будем записывать сериализованный объект
            {
                xms.Serialize(fs, this); //сериализуем
            }
        }
        public Complex Deserialize() //десериализация
        {
            FileStream fs = new FileStream(text, FileMode.Open, FileAccess.Read);
            Complex complex = xms.Deserialize(fs) as Complex;
            return complex;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex c = new Complex();
            c.a = 8; //объекты для сериализации
            c.b = 4;
            c.Serialize(); //вызываем метод сериализации 
            Complex c2 = c.Deserialize(); //вызываем метод десериализации
            Console.WriteLine(c2); //выводим на консоль объекты
        }
    }
}
