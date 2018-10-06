using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matches
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int matches = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i == 1)
                    matches += 4;
                else if (i % 2 == 0 && i > 2)
                    matches += 2;
                else
                    matches += 3;
            }
            Console.WriteLine(matches);
        }
    }
}
