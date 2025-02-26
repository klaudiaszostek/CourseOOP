namespace DILEMMA
{
    class StrategyGoodTillOpponentGoesBad : IStrategy
    {
        public bool GetNextMove(List<bool> knownMoves)
        {
            if (knownMoves.Contains(false))
            {
                return false;
            }
            return true;
        }
    }
}