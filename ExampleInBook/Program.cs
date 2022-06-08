using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExampleInBook
{
    class Program
    {
        static void Countdown(int i)
        {
            Console.WriteLine(i); 
            if (i <= 1) return;     // Базовый случай
            else Countdown(i - 1); // Рекурсивный случай
        }
        static void Greet(string name)
        {
            Console.WriteLine("Hello, " + name + "!");
            Greet2(name);
            Console.WriteLine("Getting ready to say bye...");
            Bye();
        }
        static void Greet2(string name)
        {
            Console.WriteLine("How are you, " + name + "?");
        }
        static void Bye()
        {
            Console.WriteLine("Ok bye!");
        }
        static int Fact(int x)
        {
            if (x == 1) return 1;
            else return x * Fact(x - 1);
        }
        static void Main(string[] args)
        {
            Countdown(3);
            Greet("Maggie");
            Console.WriteLine(Fact(3));
        }
    }
}
