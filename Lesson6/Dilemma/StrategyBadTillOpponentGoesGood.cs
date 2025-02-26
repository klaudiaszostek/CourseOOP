namespace DILEMMA
{
    class StrategyBadTillOpponentGoesGood : IStrategy
    {
        public bool GetNextMove(List<bool> knownMoves)
        {
            if (knownMoves.Contains(true))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}