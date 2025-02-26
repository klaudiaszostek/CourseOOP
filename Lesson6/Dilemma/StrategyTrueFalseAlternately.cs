namespace DILEMMA
{
    class StrategyTrueFalseAlternately : IStrategy
    {
        public bool GetNextMove(List<bool> knownMoves)
        {
            foreach (bool b in knownMoves)
            { 
                 if(knownMoves.IndexOf(b) % 2 == 0)
                 {
                     return true;
                 }
            }
            return false;
        }
    }
}