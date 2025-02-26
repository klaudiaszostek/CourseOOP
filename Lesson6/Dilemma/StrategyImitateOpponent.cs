namespace DILEMMA
{
    class StrategyImitateOpponent : IStrategy
    {
        public bool GetNextMove(List<bool> knownMoves)
        {
            bool recent = knownMoves.LastOrDefault();
            
            if (recent == false)
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