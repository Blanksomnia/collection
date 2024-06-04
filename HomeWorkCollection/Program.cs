using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWorkCollection
{

   
     class Tasks
     {
        public void TaskLoop()
        {
            var object1 = new TaskThree();
            Console.WriteLine("Введите exit, чтобы выйти, или нажмите enter, чтобы открыть меню");
            string Exit = Console.ReadLine();
            Console.Write("1 - Задача 1 ### 2 - Задача 2 ### 3 - Задача 3\n-> ");
            int task = int.Parse(Console.ReadLine());
            switch (task)
            {
                case 1:
                    {
                        Console.WriteLine("\nВыбрано задача 1\n");
                        Task();
                        TaskLoop();
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("\nВыбрано задача 2\n");
                        TaskTwo();
                        TaskLoop();
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("\nВыбрано задача 3\n");
                        object1.Task3();
                        TaskLoop();
                    }
                    break;
            }
        }
        public void Task()
        {
                Console.Write("введите новую строк:");
                var list = new List<string>() { Console.ReadLine(), "apple", "number", "secret", "45173" };
                Console.WriteLine("-----первая строка поменялась-----");
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i]);
                }
                Console.Write("введите новую строк:");
                list[2] = Console.ReadLine();
                Console.WriteLine("-----третья строка поменялась-----");
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i]);
                }
        }
        private Dictionary<string, int> list1 = new Dictionary<string, int>();
        public void TaskTwo()
        {
                bool while0 = false;
                while (while0 == false)
                {
                    Console.Write("введите имя ученика: ");
                    string name = Console.ReadLine();
                    Console.Write("введите оценку от 2 до 5 ученику: ");
                    string number = Console.ReadLine();
                    if (number == "2" || number == "3" || number == "4" || number == "5")
                    {
                        list1.Add(name, Convert.ToInt32(number));
                    }
                    else
                    {
                        Console.WriteLine("Введена неправильно оценка, повторите попытку: ");
                    }
                    Console.Write("нажмите Enter, чтобы добавить ученика ### нажмите done, чтобы завершить: ");
                    if (Console.ReadLine() == "done")
                    {
                        while0 = true;
                    }
                };
            TaskTwo1();
        }
        public void TaskTwo1()
        {
            bool while0 = true;
                foreach (KeyValuePair<string, int> kvp in list1)
                {
                    Console.WriteLine("имя - {0}", kvp.Key);
                }
                while (while0 == true)
                {
                    Console.Write("Выберите имя из списка: ");
                    string f = Console.ReadLine();
                    foreach (KeyValuePair<string, int> kvp in list1)
                    {
                        if(f == kvp.Key)
                        {
                            Console.WriteLine("имя ученика - {0}, оценка - {1}", kvp.Key, kvp.Value);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    Console.WriteLine("напишите STOP, чтобы перейти в меню");
                    if (f == "STOP") 
                    {
                        while0 = false;
                    }
                }
                TaskLoop();
        } 
     }



    class TaskThree
    {
        public void Task3()
        {
                var list = new LinkedList<string>() { };
                var object1 = new Tasks();
                Console.WriteLine("создайте список от 3 до 6 элементом: ");
                string readline = Console.ReadLine();
                list.AddFirst(readline);
                var current = list.Find(readline);
                for (int i = 0; i < 5; i++)
                {
                    
                    string listadd = Console.ReadLine();
                    if (listadd == "" && i <= 6 && i >= 3)
                    {
                        break;
                    }
                    list.AddBefore(current, listadd);
                }
                list.RemoveLast();
                list.AddFirst(readline);
                Console.WriteLine("\nпорядок -");
                foreach (string a in list)
                {
                    Console.WriteLine(a);
                }
                object1.TaskLoop();
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var object1 = new Tasks();
            object1.TaskLoop();
            
            
        }
    }
}
