using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Task1a
{
    public class Complex
    {
        public double a;
        public double b;
        public void PrintInfo()
        {
            Console.WriteLine("{0} + {1}i", a, b);
        }
        public override string ToString()
        {
            return string.Format("{0}+{1}i", a, b);
        }
        public void Serialize()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Complex));
            using (FileStream fs = new FileStream("Complex.txt", FileMode.Create, FileAccess.Write))
            {
                xs.Serialize(fs,this);
            }
        }
        public Complex Deserialize()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Complex));
            FileStream fs = new FileStream("Complex.txt", FileMode.Open, FileAccess.Write);
            Complex complex = xs.Deserialize(fs) as Complex;
            fs.Close();
            return complex;
            
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex cs = new Complex();
                   cs.a = 5;
            cs.b = 8;
            cs.PrintInfo();
            cs.Serialize();
            Complex cs1 = cs.Deserialize();
            Console.WriteLine(cs1);
        }
    }
}
