namespace DILEMMA
{
    interface IStrategy
    {
        bool GetNextMove(List<bool> knownMoves);
    }
}