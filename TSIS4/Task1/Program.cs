using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task1
{
    public class Complex
    {
        public double a;
        public double b;

        public void Ser()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Complex));
            FileStream fs = new FileStream("complex.txt", FileMode.Create, FileAccess.Write);
            xs.Serialize(fs, this);
            fs.Close();
        }
        public override string ToString()
        {
            return string.Format("{0}+ {1}i", a, b);
        }
        public Complex Des()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Complex));
            FileStream fs = new FileStream("complex.txt", FileMode.Open, FileAccess.Read);
            Complex complex = xs.Deserialize(fs) as Complex;
            fs.Close();
            Console.WriteLine(complex.ToString());
            return complex;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex c = new Complex();
            c.a = 3;
            c.b = 5;
            c.Ser();
            c.Des();
        }
    }
}
