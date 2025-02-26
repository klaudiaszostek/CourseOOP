namespace SIMULATOR
{
    class MoveSouth : Move
    {
        public override string Execute(int currentTime)
        {
            string direction = "south direction";
            if (currentTime >= 10 && currentTime < 14)
            {
                return direction + ", covering your eyes";
            }
            else
            {
                return direction;
            }
        }
    }
}