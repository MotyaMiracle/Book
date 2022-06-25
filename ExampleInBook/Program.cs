using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExampleInBook
{
    class Program
    {
        static void Main(string[] args)
        {
            if (word_a[i] == word_b[j])
            {
                cell[i][j] == cell[i - 1][j - 1] + 1;
            }
            else
            {
                cell[i][j] = Math.Max(cell[i - 1][j], cell[i][j - 1]);
            }
        }
    }
}
