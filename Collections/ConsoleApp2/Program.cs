using System.Collections;
using System.Diagnostics;

namespace Сollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int elementToFind = 496753;

            Stopwatch StopwatchList = new Stopwatch();
            Stopwatch StopwatchArrayList = new Stopwatch();
            Stopwatch StopwatchLinkedList = new Stopwatch();
            Stopwatch StopwatchTime1 = new Stopwatch();
            Stopwatch StopwatchTime2 = new Stopwatch();
            Stopwatch StopwatchTime3 = new Stopwatch();

            // Создание List
            List<int> list = new List<int>();
            StopwatchList.Start();
            for (int i = 1; i <= 1000000; i++)
            {
                list.Add(i);
            }
            StopwatchList.Stop();
            Console.WriteLine("Время заполнения коллекции List: " + StopwatchList.ElapsedMilliseconds + " мс");
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
            Console.WriteLine("Время заполнения коллекции ArrayList: " + StopwatchArrayList.ElapsedMilliseconds + " мс");
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
            Console.WriteLine("Время заполнения коллекции LinkedList: " + StopwatchLinkedList.ElapsedMilliseconds + " мс");
            StopwatchTime3.Start();
            int foundElement3 = list[elementToFind - 1];
            StopwatchTime3.Stop();
            TimeSpan searchTime3 = StopwatchTime3.Elapsed;
            Console.WriteLine($"Найденный элемент в коллекции LinkedList: {foundElement3}");
            Console.WriteLine($"Время поиска элемента в коллекции LinkedList: {searchTime3.TotalMilliseconds} мс \n");


            Console.WriteLine("Количество элементов в List: " + list.Count);
            Console.WriteLine("Количество элементов в ArrayList: " + arrayList.Count);
            Console.WriteLine("Количество элементов в LinkedList: " + linkedList.Count);

            Console.ReadKey();
        }
    }
}
