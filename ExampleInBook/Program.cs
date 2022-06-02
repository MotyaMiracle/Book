using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExampleInBook
{
    class Program
    {
        static string binary_search(int[] list, int item)
        {
            int low = 0;
            int high = list.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int guess = list[mid];
                if (guess == item) return Convert.ToString(mid);
                if (guess > item) high = mid - 1;
                else low = mid + 1;
            }
            return "None";

        }
        static void Main(string[] args)
        {
            int[] my_list = new int[] { 1, 3, 5, 7, 9 };

            Console.WriteLine(binary_search(my_list, 3));
            Console.WriteLine(binary_search(my_list, -1));
        }
    }
}
