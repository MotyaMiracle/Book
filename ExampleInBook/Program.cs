using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExampleInBook
{
    class Program
    {
        const double infinity = double.PositiveInfinity;
        static Dictionary<string, Dictionary<string, double>> graph = new Dictionary<string, Dictionary<string, double>>();
        static List<string> processed = new List<string>();


        static void Main(string[] args)
        {
            graph.Add("start", new Dictionary<string, double>());
            graph["start"].Add("a", 6.0);
            graph["start"].Add("b", 2.0);

            graph.Add("a", new Dictionary<string, double>());
            graph["a"].Add("fin", 1.0);

            graph.Add("b", new Dictionary<string, double>());
            graph["b"].Add("a", 3.0);
            graph["b"].Add("fin", 5.0);

            graph.Add("fin", new Dictionary<string, double>());

            var costs = new Dictionary<string, double>();
            costs.Add("a", 6.0);
            costs.Add("b", 2.0);
            costs.Add("fin", infinity);


            var parents = new Dictionary<string, string>();
            parents.Add("a", "start");
            parents.Add("b", "start");
            parents.Add("in", null);

            var node = FindLowestCostNode(costs);
            while (node != null)
            {
                var cost = costs[node];
                var neighbors = graph[node];
                foreach (var item in neighbors.Keys)
                {
                    var newCost = cost + neighbors[item];
                    if (costs[item] > newCost)
                    {
                        costs[item] = newCost;
                        parents[item] = node;
                    }
                }
                processed.Add(node);
                node = FindLowestCostNode(costs);
            }
            Console.WriteLine(string.Join(", ", costs));
        }

        static string FindLowestCostNode(Dictionary<string, double> costs)
        {
            var lowestCost = infinity;
            string lowestCostNode = null;
            foreach (var node in costs)
            {
                var cost = node.Value;
                if (cost < lowestCost && !processed.Contains(node.Key))
                {
                    lowestCost = cost;
                    lowestCostNode = node.Key;
                }

            }
            return lowestCostNode;
        }
    }
}
