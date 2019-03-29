using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Task1
{
    public class Complex
    {
        public double a;
        public double b;
        XmlSerializer xs = new XmlSerializer(typeof(Complex));
        public void PrintInfo()
        {
            Console.WriteLine(string.Format("{0} + {1}i",a,b));
        }
        public override string ToString()
        {
            return string.Format("{0}+{1}i",a,b);
        }

        public void Ser()
        {
            using (FileStream fs = new FileStream("Complex.txt", FileMode.Create, FileAccess.Write))
            {
                xs.Serialize(fs,this);
            }
        }
        public Complex Des()
        {
            FileStream fs = new FileStream("Complex.txt", FileMode.Open, FileAccess.Read);
            Complex complex = xs.Deserialize(fs) as Complex;
            fs.Close();
            return complex;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex c = new Complex();
            c.a = 3;
            c.b = 4;
            //c.PrintInfo();
            c.Ser();
            Complex c2 = c.Des();
            Console.WriteLine(c2);

        }
    }
}
