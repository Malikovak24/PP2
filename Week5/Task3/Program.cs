using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task2
{
    [Serializable]
    public class Mark
    {
        public int point { get; set; }
        public string letter;
        public string getLetter()
        {
            if (point >= 95)
                return letter = "A";
            if (point >= 90)
                return letter = "A-";
            if (point >= 85)
                return letter = "B+";
            if (point >= 80)
                return letter = "B";
            if (point >= 75)
                return letter = "B-";
            if (point >= 70)
                return letter = "C+";
            if (point >= 65)
                return letter = "C";
            if (point >= 60)
                return letter = "C-";
            if (point >= 55)
                return letter = "D";
            return letter = "F";
        }
        public override string ToString()
        {
            return ("Grade : " + point + " " + letter);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Mark> marks = new List<Mark>();
            string[] points = Console.ReadLine().Split();
            for (int i = 0; i < points.Length; i++)
            {
                Mark ex = new Mark { point = Convert.ToInt32(points[i]) };
                ex.getLetter();
                marks.Insert(i, ex);
            }

            foreach (Mark value in marks)
                Console.WriteLine(value.ToString());
            Console.WriteLine();
            //Deser();
            Ser(marks);
        }
        static void Ser(List<Mark> marks)
        {
            FileStream fs = new FileStream(@"output.txt", FileMode.Create, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(List<Mark>));
            xs.Serialize(fs, marks);
            fs.Close();
        }
        static void Deser()
        {
            FileStream fs = new FileStream(@"output.txt", FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(List<Mark>));
            List<Mark> t = xs.Deserialize(fs) as List<Mark>;
            foreach (Mark value in t)
            Console.Write(value.ToString());
            fs.Close();
        }
    }
}