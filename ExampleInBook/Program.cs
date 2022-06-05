using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExampleInBook
{
    class Program
    {
        static int[] SelectionSort(int[] array)
        {

            for (int i = 0; i < array.Length - 1; i++)
            {
                //поиск минимального числа
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                //обмен элементов
                int temp = array[min];
                array[min] = array[i];
                array[i] = temp;
            }
            return array;
        }
        static void Main(string[] args)
        {
            int[] my_array = new int[] { 5, 3, 6, 2, 10 };
            Console.WriteLine("Отсортированный массив:");
            SelectionSort(my_array);
            for (int i = 0; i < my_array.Length; i++)
            {
                Console.WriteLine(my_array[i]);
            }
            Console.ReadLine();
        }
    }
}
