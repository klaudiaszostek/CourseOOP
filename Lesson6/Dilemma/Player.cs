namespace DILEMMA
{
    class Player
    {
        private IStrategy currentStrategy; 
        public List<bool> PartnerMoves { get; set; } 
        public int Score { get; set; } 

        public Player(IStrategy initialStrategy)
        {
            PartnerMoves = new List<bool>();
            currentStrategy = initialStrategy;
        }
        public void SetStrategy(IStrategy newStrategy)
        {
            currentStrategy = newStrategy;
        }

        public bool GetNextMove()
        {
            return currentStrategy.GetNextMove(PartnerMoves);
        }

    }
}