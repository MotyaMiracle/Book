using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExampleInBook
{
    class Program
    {
        static int Sum(int[] array)
        {
            int total = 0;
            foreach (int x in array)
            {
                total += x;
            }
            return total;
        }
        static int RecursionCount(IEnumerable<int>List)
        {
            if (!List.Any()) return 0;
            else
                return 1 + RecursionCount(List.Skip(1));
        }
        static int RecursionSum(IEnumerable<int> list)
        {
            if (!list.Any()) return 0;

            return list.Take(1).First() + RecursionSum(list.Skip(1));
        }
        static int Max(IEnumerable<int> list)
        {
            if (!list.Any()) throw new ArgumentException(nameof(list));
            if (list.Count() == 1) return list.First();
            if (list.Count() == 2) return list.First() > list.Skip(1).Take(1).First() ? list.First() : list.Skip(1).Take(1).First();
            int sub_max = Max(list.Skip(1));
            return list.First() > sub_max ? list.First() : sub_max;
        }
        static void Main(string[] args)
        {
            int[] my_array = new int[] { 1, 2, 3, 4 };
            Console.WriteLine(Sum(my_array));
            Console.WriteLine(RecursionCount(new[] { 1, 2, 3, 4 }));
            Console.WriteLine(RecursionSum(new[] { 1, 2, 3, 4 }));
            Console.WriteLine(Max(new[] { 1, 3, 2, 5, 9, 8 }));
        }
    }
}
