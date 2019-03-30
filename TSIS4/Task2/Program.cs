using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task2
{
    public class Student
    {
        private string name;
        private string uni;
        private string id;
        public string N
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string U
        {
            get
            {
                return uni;
            }
            set
            {
                uni = value;
            }
        }
        public string I
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }





    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student { N = "Kami", U = "Kbtu", I = "18bd139931" };
            Ser(s);
            Des(s);
        }
        static void Ser(Student x)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Student));
            FileStream fs = new FileStream("student.txt", FileMode.Create, FileAccess.Write);
            xs.Serialize(fs, x);
            fs.Close();
        }
        static void Des(Student x)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Student));
            FileStream fs = new FileStream("student.txt", FileMode.Open, FileAccess.Read);
            Student s = xs.Deserialize(fs) as Student;
            Console.WriteLine(s.N + s.U + s.I);
            fs.Close();
        }
    }
}
