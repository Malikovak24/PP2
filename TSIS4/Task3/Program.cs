using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    [Serializable]
    class Shop
    {
        [NonSerialized]
        List<string> products = new List<string> { "Bread", "Sugar", "Eggs", "Milk" };
        public string customerName;
        public string chose;
        public string Chose
        {
            get
            {
                return chose;
            }
            set
            {
                bool found = false;
                for (int i = 0; i < products.Count; i++)
                {
                    if (value == products[i])
                    {
                        found = true;
                        break;
                    }
                }
                if (found == true)
                {
                    chose = value;
                }
                else
                {
                    chose = "Not found";
                }
            }
        }

        public void ShowProducts()
        {
            foreach (var el in products)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
        }

        public void Show()
        {
            Console.WriteLine(customerName + " " + Chose);
        }

        public void Buy()
        {
            BinaryFormatter bin = new BinaryFormatter();
            using (FileStream fs = new FileStream(@"C:\Users\aruzh\OneDrive\Рабочий стол\shop.bin", FileMode.OpenOrCreate))
            {
                bin.Serialize(fs, this);
            }
        }

        public void WriteToFile()
        {
            using (StreamWriter sr = new StreamWriter(@"C:\Users\aruzh\OneDrive\Рабочий стол\shop1.txt", true))
            {
                sr.WriteLine("Name " + customerName + " Product " + Chose);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shop s1 = new Shop();
            s1.customerName = Console.ReadLine();
            s1.ShowProducts();
            s1.Chose = Console.ReadLine();
            s1.Show();
            s1.Buy();
            s1.WriteToFile();
        }
    }
}