using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExampleInBook
{
    class Program
    {
        static Dictionary<string, bool> voted = new Dictionary<string, bool>();
        static void Main(string[] args)
        {
            var book = new Dictionary<string, double>();
            book.Add("apple", 0.67);
            book.Add("milk", 1.49);
            book.Add("avocado", 1.49);

            foreach (var item in book)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            CheckVoter("Tom");
            CheckVoter("Mike");
            CheckVoter("Mike");
        }
        static void CheckVoter(string Name)
        {
            if (voted.ContainsKey(Name)) Console.WriteLine("Kick them out!");
            else
            {
                voted.Add(Name, true);
                Console.WriteLine("Let them vote!");
            }

        }
    }    
}
