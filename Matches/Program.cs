using System;


namespace Matches
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            MatchSolution sln = new MatchSolution();
            sln.CalculateMatchesCount(n);
            Console.WriteLine(sln.ToString());
        }
    }
}
