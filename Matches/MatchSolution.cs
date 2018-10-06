namespace Matches
{
    static public class MatchSolution
    {
        static public void CalculateMatchesCount(ref int  matches, int n)
        {
            
            for (int i = 1; i <= n; i++)
            {
                if (i == 1)
                    matches += 4;
                else if (i % 2 == 0 && i > 2)
                    matches += 2;
                else
                    matches += 3;
            }
        }
    }
}
