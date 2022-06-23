using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExampleInBook
{
    class Program
    {
        static Dictionary<string, string[]> graph = new Dictionary<string, string[]>();
        static bool Search(string name)
        {
            var searchQueue = new Queue<string>(graph[name]);
            var searched = new List<string>();
            while (searchQueue.Any())
            {
                var person = searchQueue.Dequeue();
                if (!searched.Contains(person))
                {
                    if (PersonIsSeller(person))
                    {
                        Console.WriteLine(person + " is a mango seller!");
                        return true;
                    }
                    else
                    {
                        searchQueue = new Queue<string>(searchQueue.Concat(graph[person]));
                        searched.Add(person);
                    }
                }                
            }
            return false;
        }
        static bool PersonIsSeller(string name)
        {
            return name.EndsWith("m");
        }
        static void Main(string[] args)
        {
            
            graph.Add("you", new[] {"alice", "bob", "claire"});
            graph.Add("bob", new[] {"anuj", "peggy"});
            graph.Add("alice", new[] {"peggy"});
            graph.Add("claire", new[] {"thom", "jonny"});
            graph.Add("anuj", Array.Empty<string>());
            graph.Add("peggy", Array.Empty<string>());
            graph.Add("thom", Array.Empty<string>());
            graph.Add("jonny", Array.Empty<string>());
            Search("you");
        }
    }
}
