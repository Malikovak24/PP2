using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Task2
{
    public class Mark
    {
        public int points;
        public string mark;
        public override string ToString()
        {
            return string.Format("{0}-{1}",points,mark);
        }
        public void Serialize()
        {
            List<Mark> point = new List<Mark>();
            point.Add(new Mark() { points = 98, mark = "A" });
            point.Add(new Mark() { points = 70, mark = "C+" });
            point.Add(new Mark() { points = 80, mark = "B" });
            XmlSerializer xs = new XmlSerializer(typeof(List<Mark>));           
            using (FileStream fs = new FileStream("Marks.txt", FileMode.Create, FileAccess.Write))
            {
                xs.Serialize(fs,this);
            }
        }
        public Mark Deserialize()
        {
            List<Mark> point = new List<Mark>();
            point.Add(new Mark() { points = 98, mark = "A" });
            point.Add(new Mark() { points = 70, mark = "C+" });
            point.Add(new Mark() { points = 80, mark = "B" });
            XmlSerializer xs = new XmlSerializer(typeof(List<Mark>));
            FileStream fs = new FileStream("Marks.txt", FileMode.Open, FileAccess.Read);
            Mark m = xs.Deserialize(fs) as Mark;
            return m;

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Mark mar = new Mark();
            mar.Serialize();
            


        }
    }
}
