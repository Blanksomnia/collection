﻿using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeWorkCollection
{

   
     class Tasks
     {
        public string TaskLoop(string f)
        {
            Console.WriteLine("Введите exit, чтобы выйти, или нажмите enter, чтобы продолжить");
            string Exit = Console.ReadLine();
            if (Exit != "exit")
            {
                if(f == "task")
                {
                    return Task;
                }
                else if (f == "task2")
                {
                    return TaskTwo1;
                } 
            }
            return "complete";
        }
        public string Task
        {
            
            get
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
                return TaskLoop("task");
            }
        }
        private Dictionary<string, int> list1 = new Dictionary<string, int>();
        public string TaskTwo
        {
            get
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
                        return TaskTwo;
                    }
                    Console.Write("нажмите Enter, чтобы добавить ученика ### нажмите done, чтобы завершить: ");
                    if (Console.ReadLine() == "done")
                    {
                        while0 = true;
                    }
                };
                return TaskTwo1;
            }
        }
        public string TaskTwo1 {
            get
            {
                foreach (KeyValuePair<string, int> kvp in list1)
                {
                    Console.WriteLine("имя - {0}", kvp.Key);
                }
                while (true)
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
                        return TaskLoop("task2");
                    }
                }
            } 
        } 
     }

    

    // class TaskThree
    //{
    //    public string Task3 { get 
    //        {
    //            var list = new List<string>() { };
    //            Console.WriteLine("создайте список от 3 до 6 элементом: ");
    //            for (int i = 0; i < 6; i++)
    //            {
    //                string listadd = Console.ReadLine();
    //                if (listadd == "" && i <= 6 && i >= 3)
    //                {
    //                    break;
    //                }
    //                list.Add(listadd);
    //            }
    //            Console.WriteLine("\nпорядок -");
    //            for (int a = 0; a < list.Count; a++)
    //            {
    //                Console.WriteLine(list[a]);
    //            }
    //            list.Reverse();
    //            Console.WriteLine("\nобратный порядок -");
    //            for (int a = 0; a < list.Count; a++)
    //            {
    //                Console.WriteLine(list[a]);
    //            }
    //        } 
    //    }

    //}
    internal class Program
    {
        static void Main(string[] args)
        {
        var object1 = new Tasks();
            Console.Write("1 - Задача 1 ### 2 - Задача 2 ### 3 - Задача 3\n-> ");
            int task = int.Parse(Console.ReadLine());
            switch (task)
            {
                case 1:
                    {
                        Console.WriteLine("\nВыбрано задача 1\n");
                        Console.WriteLine(object1.Task);
                    }
                    return;
                case 2:
                    {
                        Console.WriteLine("\nВыбрано задача 2\n");
                        Console.WriteLine(object1.TaskTwo);
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("\nВыбрано задача 3\n");

                    }
                    break;
            }
        }
    }
}
