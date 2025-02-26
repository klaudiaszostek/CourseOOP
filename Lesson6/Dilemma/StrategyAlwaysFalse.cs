namespace DILEMMA
{
    class StrategyAlwaysFalse : IStrategy
    {
        public bool GetNextMove(List<bool> knownMoves)
        {
            return false;
        }
    }
}