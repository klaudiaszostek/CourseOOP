namespace DILEMMA
{
    class StrategyCheckCredibility : IStrategy
    {
        public bool GetNextMove(List<bool> knownMoves)
        {
            int betrayals = 0;
            foreach (bool b in knownMoves)
            {
                if (b == false)
                {
                    betrayals++;
                }
            }
            if (betrayals > 1 / 2 * knownMoves.Count)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}