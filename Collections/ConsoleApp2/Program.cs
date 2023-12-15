using System.Collections;
using System.Diagnostics;

namespace Сollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int elementToFind = 496753;

                Stopwatch StopwatchList = new Stopwatch();
                Stopwatch StopwatchArrayList = new Stopwatch();
                Stopwatch StopwatchLinkedList = new Stopwatch();
                Stopwatch StopwatchTime1 = new Stopwatch();
                Stopwatch StopwatchTime2 = new Stopwatch();
                Stopwatch StopwatchTime3 = new Stopwatch();
                Stopwatch Stopwatch1777 = new Stopwatch();
                Stopwatch Stopwatch2777 = new Stopwatch();
                Stopwatch Stopwatch3777 = new Stopwatch();

                // Создание List
                List<int> list = new List<int>();
                StopwatchList.Start();
                for (int i = 1; i <= 1000000; i++)
                {
                    list.Add(i);
                }
                StopwatchList.Stop();
                Stopwatch1777.Start();
                Console.Write($"Элемент коллекции List, который без остатка делится на 777:\n");
                foreach (int num in list)
                {
                    if (num % 777 == 0)
                    {
                        Console.Write($"{num}");
                    }
                }
                Stopwatch1777.Stop();
                Console.WriteLine("\nВремя заполнения коллекции List: " + StopwatchList.ElapsedMilliseconds + " мс");
                StopwatchTime1.Start();
                int foundElement1 = list[elementToFind - 1];
                StopwatchTime1.Stop();
                TimeSpan searchTime1 = StopwatchTime1.Elapsed;
                Console.WriteLine($"Найденный элемент в коллекции List: {foundElement1}");
                Console.WriteLine($"Время поиска элемента в коллекции List: {searchTime1.TotalMilliseconds} мс \n");

                // Создание ArrayList
                ArrayList arrayList = new ArrayList();
                StopwatchArrayList.Start();
                for (int i = 1; i <= 1000000; i++)
                {
                    arrayList.Add(i);
                }
                StopwatchArrayList.Stop();
                Stopwatch2777.Start();
                Console.Write($"Элемент коллекции ArrayList, который без остатка делится на 777:\n");
                foreach (int num in arrayList)
                {
                    if (num % 777 == 0)
                    {
                        Console.Write($"{num} ");
                    }
                }
                Stopwatch2777.Stop();
                Console.WriteLine("\nВремя заполнения коллекции ArrayList: " + StopwatchArrayList.ElapsedMilliseconds + " мс");
                StopwatchTime2.Start();
                int foundElement2 = list[elementToFind - 1];
                StopwatchTime2.Stop();
                TimeSpan searchTime2 = StopwatchTime2.Elapsed;
                Console.WriteLine($"Найденный элемент в коллекции ArrayList: {foundElement2}");
                Console.WriteLine($"Время поиска элемента в коллекции ArrayList: {searchTime2.TotalMilliseconds} мс \n");


                // Создание LinkedList
                LinkedList<int> linkedList = new LinkedList<int>();
                StopwatchLinkedList.Start();
                for (int i = 1; i <= 1000000; i++)
                {
                    linkedList.AddLast(i);
                }
                StopwatchLinkedList.Stop();
                Stopwatch3777.Start();
                Console.Write($"Элемент коллекции LinkedList, который без остатка делится на 777:\n");
                foreach (int num in linkedList)
                {
                    if (num % 777 == 0)
                    {
                        Console.Write($"{num} ");
                    }
                }
                Stopwatch3777.Stop();
                Console.WriteLine("\nВремя заполнения коллекции LinkedList: " + StopwatchLinkedList.ElapsedMilliseconds + " мс");
                StopwatchTime3.Start();
                int foundElement3 = list[elementToFind - 1];
                StopwatchTime3.Stop();
                TimeSpan searchTime3 = StopwatchTime3.Elapsed;
                Console.WriteLine($"Найденный элемент в коллекции LinkedList: {foundElement3}");
                Console.WriteLine($"Время поиска элемента в коллекции LinkedList: {searchTime3.TotalMilliseconds} мс \n");


                Console.WriteLine("Количество элементов в List: " + list.Count);
                Console.WriteLine("Количество элементов в ArrayList: " + arrayList.Count);
                Console.WriteLine("Количество элементов в LinkedList: " + linkedList.Count + "\n");

                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Введите 'да' чтобы запустить заново:");
                    Console.ResetColor();

                    string input = Console.ReadLine();

                    if (input.ToLower() == "да")
                    {
                        Console.WriteLine("Вы ввели 'да'. \n");
                        break;
                    }
                    else if (input.ToLower() == "нет")
                    {
                        Console.WriteLine("Вы ввели 'нет'.\n");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели неверное значение. Пожалуйста, повторите попытку.");
                    }
                }


            }
        }
    }
}
