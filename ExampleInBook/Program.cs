using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExampleInBook
{
    class Program
    {
        static IEnumerable<int> QuickSort(IEnumerable<int> List)
        {
            if (List.Count() < 1) return List;
            else
            {
                var pivot = List.First();
                var less = List.Skip(1).Where(i => i <= pivot);
                var greater = List.Skip(1).Where(i => i > pivot);
                return QuickSort(less).Union(new List<int> { pivot }).Union(QuickSort(greater));
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 5, 2, 3 };
            Console.WriteLine(string.Join(", ", QuickSort(arr)));
        }
    }
}
