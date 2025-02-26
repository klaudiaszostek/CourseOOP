namespace DILEMMA
{
    class StrategyAlwaysTrue : IStrategy
    {
        public bool GetNextMove(List<bool> knownMoves)
        {
            return true;
        }
    }
}