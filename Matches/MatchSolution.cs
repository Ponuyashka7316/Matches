namespace Matches
{
    public class MatchSolution
    {
        private int matches;
        public MatchSolution()
        {
            matches = 0;
        }

       public void CalculateMatchesCount(int n)
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

        public override string ToString() {
            return "Matches: " + matches;
        }
    }
}
