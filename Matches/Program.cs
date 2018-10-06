using System;


namespace Matches
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int matches = 0;
            MatchSolution.CalculateMatchesCount(ref matches, n);
            Console.WriteLine(matches);
        }
    }
}
