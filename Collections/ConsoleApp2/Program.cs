using System.Collections;
using System.Diagnostics;

namespace Сollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int elementToFind = 496753;

            Stopwatch Stopwatch = new Stopwatch();
            // Создание List
            List<int> list = new List<int>();
            Stopwatch.Start();
            for (int i = 1; i <= 1000000; i++)
            {
                list.Add(i);
            }
            Stopwatch.Stop();
            Console.WriteLine("Время заполнения коллекции List: " + Stopwatch.ElapsedMilliseconds + " мс");
            Stopwatch.Start();
            int foundElement1 = list[elementToFind - 1];
            Stopwatch.Stop();
            TimeSpan searchTime1 = Stopwatch.Elapsed;
            Console.WriteLine($"Найденный элемент в коллекции List: {foundElement1}");
            Console.WriteLine($"Время поиска элемента в коллекции List: {searchTime1.TotalMilliseconds} мс");
            // Создание ArrayList
            ArrayList arrayList = new ArrayList();
            Stopwatch.Start();
            for (int i = 1; i <= 1000000; i++)
            {
                arrayList.Add(i);
            }
            Stopwatch.Stop();
            Console.WriteLine("Время заполнения коллекции ArrayList: " + Stopwatch.ElapsedMilliseconds + " мс");
            Stopwatch.Start();
            int foundElement2 = list[elementToFind - 1];
            Stopwatch.Stop();
            TimeSpan searchTime2 = Stopwatch.Elapsed;
            Console.WriteLine($"Найденный элемент в коллекции ArrayList: {foundElement2}");
            Console.WriteLine($"Время поиска элемента в коллекции ArrayList: {searchTime2.TotalMilliseconds} мс");

            // Создание LinkedList
            LinkedList<int> linkedList = new LinkedList<int>();
            Stopwatch.Start();
            for (int i = 1; i <= 1000000; i++)
            {
                linkedList.AddLast(i);
            }
            Stopwatch.Stop();
            Console.WriteLine("Время заполнения коллекции LinkedList: " + Stopwatch.ElapsedMilliseconds + " мс");
            Stopwatch.Start();
            int foundElement3 = list[elementToFind - 1];
            Stopwatch.Stop();
            TimeSpan searchTime3 = Stopwatch.Elapsed;
            Console.WriteLine($"Найденный элемент в коллекции ArrayList: {foundElement3}");
            Console.WriteLine($"Время поиска элемента в коллекции ArrayList: {searchTime3.TotalMilliseconds} мс");


            Console.WriteLine("Количество элементов в List: " + list.Count);
            Console.WriteLine("Количество элементов в ArrayList: " + arrayList.Count);
            Console.WriteLine("Количество элементов в LinkedList: " + linkedList.Count);

            
        }
    }
}
