using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Example1
{
    enum FSIMode //создаем нумерованный список
    {
        DirectoryInfo = 1, // Справочник //пишем в списке два состояния:файл и папка
        File = 2
    }
    class Layer //создаем класс
    {
        public DirectoryInfo[] DirectoryContent //создаем переменную для папок
        {
            get;
            set;
        }
        public FileInfo[] FileContent //для файлов
        {
            get;
            set;
        }
        public int SelectedIndex
        {
            get;
            set;
        }
        void SelectedColor(int i)
        {
            if (i == SelectedIndex)
                Console.BackgroundColor = ConsoleColor.Red;
            else
                Console.BackgroundColor = ConsoleColor.Black;
        }
        public void Draw() //создаю метод
        {
            Console.BackgroundColor = ConsoleColor.Black; 
            Console.Clear(); //очищаем консоль
            for (int i = 0; i < DirectoryContent.Length; ++i)
            {
                SelectedColor(i); //вызываю функцию 
                Console.WriteLine((i + 1) + ". " + DirectoryContent[i].Name); //вывожу порядок папки и его название
            }
            Console.ForegroundColor = ConsoleColor.Yellow; //цвет букв файлов желтый
            for (int i = 0; i < FileContent.Length; ++i)
            {
                SelectedColor(i + DirectoryContent.Length); //вызываю функцию с параметром (i+кол-во папок) для файлов
                Console.WriteLine((i + DirectoryContent.Length + 1) + ". " + FileContent[i].Name); //вывожу порядок файла и его название
            }
            Console.ForegroundColor = ConsoleColor.White; //цвет букв папок белый
        }
    }
    class Program
    {
        static bool pathExists(string path, int mode) //создаю функцию для проверки есть путь папки или нет
        {
            if ((mode == 1 && new DirectoryInfo(path).Exists) || (mode == 2 && new FileInfo(path).Exists))
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Asus\source\repos"); 
            if (!dir.Exists) //если папке не существует
            {
                Console.WriteLine("Directory not exist"); //вывожу на консоль что ее нет
                return;
            }
            Layer l = new Layer //
            {
                DirectoryContent = dir.GetDirectories(), //directorycontent содержит в себе папки внутри папки
                FileContent = dir.GetFiles(), //filecomtent содержит в себе файлы папки
                SelectedIndex = 0 
            };
            Stack<Layer> history = new Stack<Layer>();
            history.Push(l);
            bool esc = false;
            FSIMode curMode = FSIMode.DirectoryInfo; //вызываю нумерованный список 
            while (!esc) //пока не сделан выход
            {
                if (curMode == FSIMode.DirectoryInfo) //текущее состояние это папка
                {
                    history.Peek().Draw(); //вызываю функцию draw
                    Console.ForegroundColor = ConsoleColor.Blue; 
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("Delete: Del | Rename: F4 | Back: Backspace | Exit: Esc");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                ConsoleKeyInfo consolekeyInfo = Console.ReadKey();
                switch (consolekeyInfo.Key)
                {
                    case ConsoleKey.UpArrow: //если нажата клавиша стрелки вверх
                        if (history.Peek().SelectedIndex > 0) //если выбранный объект индекс больше нуля
                            history.Peek().SelectedIndex--; //то идет вниз
                        break;
                    case ConsoleKey.DownArrow:
                        if (history.Peek().DirectoryContent.Length + history.Peek().FileContent.Length - 1 > history.Peek().SelectedIndex)
                            history.Peek().SelectedIndex++; //идем вверх
                        break;
                    case ConsoleKey.Enter:
                        if (history.Peek().DirectoryContent.Length + history.Peek().FileContent.Length == 0) //если ничего нет то выходим из программы
                            break;
                        int index = history.Peek().SelectedIndex; //создаем переменную которой присваиваем значение выбранного объекта
                        if (index < history.Peek().DirectoryContent.Length) //если индекс меньше кол-ва папок
                        {
                            DirectoryInfo d = history.Peek().DirectoryContent[index]; 
                            history.Push(new Layer
                            {
                                DirectoryContent = d.GetDirectories(), //выводим его папки
                                FileContent = d.GetFiles(), //выводим файлы
                                SelectedIndex = 0
                            });
                        }
                        else
                        {
                            curMode = FSIMode.File; //если же состояние файлов то мы его открываем и выводим все что находится в файлах
                            using (FileStream fs = new FileStream(history.Peek().FileContent[index - history.Peek().DirectoryContent.Length].FullName, FileMode.Open, FileAccess.Read))
                            {
                                using (StreamReader sr = new StreamReader(fs))
                                {
                                    Console.BackgroundColor = ConsoleColor.White;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Clear();
                                    Console.WriteLine(sr.ReadToEnd());

                                }
                            }

                        }
                        break; //выходим
                    case ConsoleKey.Backspace: //если нажата клавиша "назад"
                        if (curMode == FSIMode.DirectoryInfo) //если текущее состояние папка
                        {
                            if (history.Count > 1) //если кол-во элементов больше 1
                                history.Pop(); //то мы извлекаем и возвращаем первый элемент стека
                        }
                        else
                        {
                            curMode = FSIMode.DirectoryInfo; //если текущее состояние это папка
                            Console.ForegroundColor = ConsoleColor.White; //выводим цвет букв белый
                        }
                        break; //выходим
                    case ConsoleKey.Escape: //если нажата клавиша выхода
                        esc = true; //если нажата то выходим
                        break;
                    case ConsoleKey.Delete: //если нажата клавиша удаления
                        if (curMode != FSIMode.DirectoryInfo || (history.Peek().DirectoryContent.Length + history.Peek().FileContent.Length) == 0) //если текущее состояние не папка или там ничего нет то выходим
                            break;
                        index = history.Peek().SelectedIndex; //создаю переменную
                        int ind = index;
                        if (index < history.Peek().DirectoryContent.Length) //если же папка то удаляем ее
                            history.Peek().DirectoryContent[index].Delete(true);
                        else
                            history.Peek().FileContent[index - history.Peek().DirectoryContent.Length].Delete(); //если файл то удаляем его
                        int numofcontent = history.Peek().DirectoryContent.Length + history.Peek().FileContent.Length - 2; //порядок поменялся после удаления
                        history.Pop(); //извлекаем и возвращаем первый элемент стека
                        if (history.Count == 0)
                        {
                            Layer nl = new Layer
                            {
                                DirectoryContent = dir.GetDirectories(),
                                FileContent = dir.GetFiles(),
                                SelectedIndex = Math.Min(Math.Max(numofcontent, 0), ind) 
                            };
                            history.Push(nl);
                        }
                        else
                        {
                            index = history.Peek().SelectedIndex;
                            DirectoryInfo di = history.Peek().DirectoryContent[index];
                            Layer nl = new Layer
                            {
                                DirectoryContent = di.GetDirectories(),
                                FileContent = di.GetFiles(),
                                SelectedIndex = Math.Min(Math.Max(numofcontent, 0), ind)
                            };
                            history.Push(nl);
                        }
                        break;
                    case ConsoleKey.F4: //если нажата клавиша переименования папки
                        if (history.Peek().DirectoryContent.Length + history.Peek().FileContent.Length == 0) //если ничего нет то выходим
                            break;
                        index = history.Peek().SelectedIndex;
                        string name, fullname;
                        int selectedMode;
                        if (index < history.Peek().DirectoryContent.Length) //если это папка
                        {
                            name = history.Peek().DirectoryContent[index].Name; //то берем название папки
                            fullname = history.Peek().DirectoryContent[index].FullName; //берем путь
                            selectedMode = 1;
                        }
                        else
                        {
                            name = history.Peek().FileContent[index - history.Peek().DirectoryContent.Length].Name; //если файл то также берем название файла и путь к нему
                            fullname = history.Peek().FileContent[index - history.Peek().DirectoryContent.Length].FullName;
                            selectedMode = 2;
                        }
                        fullname = fullname.Remove(fullname.Length - name.Length); //меняем путь то есть убираем в конце пути название
                        Console.WriteLine("Please enter the new name, to rename {0}:", name); 
                        Console.WriteLine(fullname); 
                        string newname = Console.ReadLine(); 
                        while (newname.Length == 0 || pathExists(fullname + newname, selectedMode)) //если не введено или такой путь существует 
                        { 
                            Console.WriteLine("This directory was created, Enter the new one"); //то выводим на экран что такое название уже есть
                            newname = Console.ReadLine(); //вводим новый
                        } 
                        Console.WriteLine(selectedMode); //выводим
                        if (selectedMode == 1) //если это папка то выводим его новое название
                        {
                            new DirectoryInfo(history.Peek().DirectoryContent[index].FullName).MoveTo(fullname + newname); 
                        }
                        else
                            new FileInfo(history.Peek().FileContent[index - history.Peek().DirectoryContent.Length].FullName).MoveTo(fullname + newname);
                        index = history.Peek().SelectedIndex;
                        ind = index;
                        numofcontent = history.Peek().DirectoryContent.Length + history.Peek().FileContent.Length - 1; 
                        history.Pop();
                        if (history.Count == 0)
                        {
                            Layer nl = new Layer
                            {
                                DirectoryContent = dir.GetDirectories(),
                                FileContent = dir.GetFiles(),
                                SelectedIndex = Math.Min(Math.Max(numofcontent, 0), ind)
                            };
                            history.Push(nl);
                        }
                        else
                        {
                            index = history.Peek().SelectedIndex;
                            DirectoryInfo di = history.Peek().DirectoryContent[index];
                            Layer nl = new Layer
                            {
                                DirectoryContent = di.GetDirectories(),
                                FileContent = di.GetFiles(),
                                SelectedIndex = Math.Min(Math.Max(numofcontent, 0), ind)
                            };
                            history.Push(nl);
                        }
                        break;
                    default:
                        break;
                }

            }
        }
    }
}

