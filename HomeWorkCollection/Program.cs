namespace HomeWorkCollection
{
    internal class Tasks
    {
        public string taskvariant { get 
            {
                Console.Write("1 - Задача 1 ### 2 - Задача 2 ### 3 - Задача 3 ### нажмите Enter или exit - Выход \n-> ");
                string readline = Console.ReadLine();
                switch (readline)
                {
                    case "1":
                        {
                            Console.WriteLine("\nВыбрано задача 1\n");
                        }
                        return Task1;
                    case "2":
                        {
                            Console.WriteLine("\nВыбрано задача 2\n");
                        }
                        return Task2;
                    case "3":
                        {
                            Console.WriteLine("\nВыбрано задача 3\n");
                        }
                        return Task3;
                    case "exit":
                        {
                        }
                        return "Завершение работы";
                    default:
                        {
                            return "Завершение работы";
                        }
                }
                return taskvariant;
            } 
        }
        public string Task1
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
                return taskvariant;
            }
        }
        public string Task2 { get
            {
                var list1 = new List<string>() { };
                var list2 = new List<string>() { };
                bool while0 = false;
                while (while0 == false)
                {
                    Console.Write("введите имя ученика: ");
                    string name = Console.ReadLine();
                    list1.Add(name);
                    Console.Write("введите оценку от 2 до 5 ученику: ");
                    string number = Console.ReadLine();
                    if (number == "2" || number == "3" || number == "4" || number == "5")
                    {
                        list2.Add(number);
                    }
                    else
                    {
                        Console.WriteLine("Введена неправильно оценка, повторите попытку: ");
                        list1.Remove(name);
                        list2.Remove(number);
                        return Task2;
                    }
                    Console.Write("нажмите Enter, чтобы добавить ещё ученика ### нажмите done, чтобы завершить: ");
                    if (Console.ReadLine() == "done")
                    {
                        while0 = true;
                    }
                };
                var while1 = false;
                while (while1 == false)
                {
                    for (int i = 0; i < list1.Count; i++)
                    {
                        Console.WriteLine("имя - {0}", list1[i]);
                    }
                    Console.Write("Выберите имя из списка: ");

                    for (int i = 0; i < list1.Count; i++)
                    {
                    if (list1[i] == Console.ReadLine())
                    {
                        Console.WriteLine("имя - {0} ### оценка - {1}", list1[i], list2[i]);
                    }
                    else
                    {
                        Console.WriteLine("Выбрано неправильное имя повторите попытку");                          
                    }
                    Console.Write("нажмите done, чтобы завершить или Выберите имя из списка: ");
                    if (Console.ReadLine() == "done")
                    {
                        while1 = true;
                    }
                    }
                }
                return taskvariant;
            } 
        }
        public string Task3 { get 
            {
                var list = new List<string>() { };
                Console.WriteLine("создайте список от 3 до 6 элементом: ");
                for (int i = 0; i < 6; i++)
                {
                    string listadd = Console.ReadLine();
                    if (listadd == "" && i <= 6 && i >= 3)
                    {
                        break;
                    }
                    list.Add(listadd);
                }
                Console.WriteLine("\nпорядок -");
                for (int a = 0; a < list.Count; a++)
                {
                    Console.WriteLine(list[a]);
                }
                list.Reverse();
                Console.WriteLine("\nобратный порядок -");
                for (int a = 0; a < list.Count; a++)
                {
                    Console.WriteLine(list[a]);
                }
                return taskvariant;
            } 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var Tasks = new Tasks();
            Console.WriteLine(Tasks.taskvariant);
        }
    }
}
