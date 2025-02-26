namespace DILEMMA
{
    class Game
    {
        public static void Run1()
        {
            int rounds = 30; // how many rounds
            int score1 = 10; // both players cooperate
            int score2 = 15; // one player betrays - winner
            int score3 = -10; // one player betrays - loser
            int score4 = 0; // both players betray
            // note: it can be shown mathematically that this game is non-trivial if: 
            // 1) score2 > score1 > score4 > score3, AND
            // 2) 2*score1 > score2 + score3


            Player p1 = new Player(new StrategyImitateOpponent());
            Player p2 = new Player(new StrategyCheckCredibility());
            for (int i = 0; i < rounds; i++)
            {
                bool move1 = p1.GetNextMove();
                bool move2 = p2.GetNextMove();

                if (move1 && move2) // both players cooperated
                {
                    // update score
                    p1.Score += score1;
                    p2.Score += score1;
                    // update players' knowledge about their partner
                    p1.PartnerMoves.Add(true);
                    p2.PartnerMoves.Add(true);
                }
                else if (move1) // player2 betrayed player1
                {
                    p1.Score += score3;
                    p2.Score += score2;
                    p1.PartnerMoves.Add(false);
                    p2.PartnerMoves.Add(true);
                }
                else if (move2) // player1 betrayed player2
                {
                    p1.Score += score2;
                    p2.Score += score3;
                    p1.PartnerMoves.Add(true);
                    p2.PartnerMoves.Add(false);
                }
                else // both players betrayed
                {
                    p1.Score += score4;
                    p2.Score += score4;
                    p1.PartnerMoves.Add(false);
                    p2.PartnerMoves.Add(false);
                }
            }

            Console.WriteLine("Player1 score: " + p1.Score);
            Console.WriteLine("Player2 score: " + p2.Score);
        }
        public static void Run2()
        {
            int rounds = 30; 
            int score1 = 10; 
            int score2 = 15; 
            int score3 = -10; 
            int score4 = 0; 

            Player p1 = new Player(new StrategyImitateOpponent());
            Player p3 = new Player(new StrategyGoodTillOpponentGoesBad());
            for (int i = 0; i < rounds; i++)
            {
                bool move1 = p1.GetNextMove();
                bool move3 = p3.GetNextMove();

                if (move1 && move3)
                {
                    p1.Score += score1;
                    p3.Score += score1;
                    p1.PartnerMoves.Add(true);
                    p3.PartnerMoves.Add(true);
                }
                else if (move1)
                {
                    p1.Score += score3;
                    p3.Score += score2;
                    p1.PartnerMoves.Add(false);
                    p3.PartnerMoves.Add(true);
                }
                else if (move3) 
                {
                    p1.Score += score2;
                    p3.Score += score3;
                    p1.PartnerMoves.Add(true);
                    p3.PartnerMoves.Add(false);
                }
                else 
                {
                    p1.Score += score4;
                    p3.Score += score4;
                    p1.PartnerMoves.Add(false);
                    p3.PartnerMoves.Add(false);
                }
            }

            Console.WriteLine("Player1 score: " + p1.Score);
            Console.WriteLine("Player3 score: " + p3.Score);
        }
        public static void Run3()
        {
            int rounds = 30; 
            int score1 = 10; 
            int score2 = 15; 
            int score3 = -10; 
            int score4 = 0; 
                            
            Player p1 = new Player(new StrategyImitateOpponent());
            Player p4 = new Player(new StrategyBadTillOpponentGoesGood());
            for (int i = 0; i < rounds; i++)
            {
                bool move1 = p1.GetNextMove();
                bool move4 = p4.GetNextMove();

                if (move1 && move4) 
                {
                    p1.Score += score1;
                    p4.Score += score1;
                    p1.PartnerMoves.Add(true);
                    p4.PartnerMoves.Add(true);
                }
                else if (move1) 
                {
                    p1.Score += score3;
                    p4.Score += score2;
                    p1.PartnerMoves.Add(false);
                    p4.PartnerMoves.Add(true);
                }
                else if (move4) 
                {
                    p1.Score += score2;
                    p4.Score += score3;
                    p1.PartnerMoves.Add(true);
                    p4.PartnerMoves.Add(false);
                }
                else 
                {
                    p1.Score += score4;
                    p4.Score += score4;
                    p1.PartnerMoves.Add(false);
                    p4.PartnerMoves.Add(false);
                }
            }

            Console.WriteLine("Player1 score: " + p1.Score);
            Console.WriteLine("Player4 score: " + p4.Score);
        }
        public static void Run4()
        {
            int rounds = 30; 
            int score1 = 10;
            int score2 = 15; 
            int score3 = -10; 
            int score4 = 0; 

            Player p1 = new Player(new StrategyImitateOpponent());
            Player p5 = new Player(new StrategyTrueFalseAlternately());
            for (int i = 0; i < rounds; i++)
            {
                bool move1 = p1.GetNextMove();
                bool move5 = p5.GetNextMove();

                if (move1 && move5)
                { 
                    p1.Score += score1;
                    p5.Score += score1;
                    p1.PartnerMoves.Add(true);
                    p5.PartnerMoves.Add(true);
                }
                else if (move1) 
                {
                    p1.Score += score3;
                    p5.Score += score2;
                    p1.PartnerMoves.Add(false);
                    p5.PartnerMoves.Add(true);
                }
                else if (move5) 
                {
                    p1.Score += score2;
                    p5.Score += score3;
                    p1.PartnerMoves.Add(true);
                    p5.PartnerMoves.Add(false);
                }
                else 
                {
                    p1.Score += score4;
                    p5.Score += score4;
                    p1.PartnerMoves.Add(false);
                    p5.PartnerMoves.Add(false);
                }
            }

            Console.WriteLine("Player1 score: " + p1.Score);
            Console.WriteLine("Player5 score: " + p5.Score);
        }
        public static void Run5()
        {
            int rounds = 30; 
            int score1 = 10; 
            int score2 = 15; 
            int score3 = -10; 
            int score4 = 0; 
                            
            Player p2 = new Player(new StrategyCheckCredibility());
            Player p3 = new Player(new StrategyGoodTillOpponentGoesBad());
            for (int i = 0; i < rounds; i++)
            {
                bool move2 = p2.GetNextMove();
                bool move3 = p3.GetNextMove();

                if (move2 && move3) 
                {
                    p2.Score += score1;
                    p3.Score += score1;
                    p2.PartnerMoves.Add(true);
                    p3.PartnerMoves.Add(true);
                }
                else if (move2) 
                {
                    p2.Score += score3;
                    p3.Score += score2;
                    p2.PartnerMoves.Add(false);
                    p3.PartnerMoves.Add(true);
                }
                else if (move3) 
                {
                    p2.Score += score2;
                    p3.Score += score3;
                    p2.PartnerMoves.Add(true);
                    p3.PartnerMoves.Add(false);
                }
                else 
                {
                    p2.Score += score4;
                    p3.Score += score4;
                    p2.PartnerMoves.Add(false);
                    p3.PartnerMoves.Add(false);
                }
            }

            Console.WriteLine("Player2 score: " + p2.Score);
            Console.WriteLine("Player3 score: " + p3.Score);
        }
        public static void Run6()
        {
            int rounds = 30; 
            int score1 = 10;
            int score2 = 15; 
            int score3 = -10; 
            int score4 = 0; 
                            
            Player p2 = new Player(new StrategyCheckCredibility());
            Player p4 = new Player(new StrategyBadTillOpponentGoesGood());
            for (int i = 0; i < rounds; i++)
            {
                bool move2 = p2.GetNextMove();
                bool move4 = p4.GetNextMove();

                if (move2 && move4) 
                {
                    p2.Score += score1;
                    p4.Score += score1;
                    p2.PartnerMoves.Add(true);
                    p4.PartnerMoves.Add(true);
                }
                else if (move2)
                {
                    p2.Score += score3;
                    p4.Score += score2;
                    p2.PartnerMoves.Add(false);
                    p4.PartnerMoves.Add(true);
                }
                else if (move4) 
                {
                    p2.Score += score2;
                    p4.Score += score3;
                    p2.PartnerMoves.Add(true);
                    p4.PartnerMoves.Add(false);
                }
                else
                {
                    p2.Score += score4;
                    p4.Score += score4;
                    p2.PartnerMoves.Add(false);
                    p4.PartnerMoves.Add(false);
                }
            }

            Console.WriteLine("Player2 score: " + p2.Score);
            Console.WriteLine("Player4 score: " + p4.Score);
        }
        public static void Run7()
        {
            int rounds = 30; 
            int score1 = 10; 
            int score2 = 15; 
            int score3 = -10; 
            int score4 = 0; 
                            
            Player p2 = new Player(new StrategyCheckCredibility());
            Player p5 = new Player(new StrategyTrueFalseAlternately());
            for (int i = 0; i < rounds; i++)
            {
                bool move2 = p2.GetNextMove();
                bool move5 = p5.GetNextMove();

                if (move2 && move5) 
                {
                    p2.Score += score1;
                    p5.Score += score1;
                    p2.PartnerMoves.Add(true);
                    p5.PartnerMoves.Add(true);
                }
                else if (move2) 
                {
                    p2.Score += score3;
                    p5.Score += score2;
                    p2.PartnerMoves.Add(false);
                    p5.PartnerMoves.Add(true);
                }
                else if (move5) 
                {
                    p2.Score += score2;
                    p5.Score += score3;
                    p2.PartnerMoves.Add(true);
                    p5.PartnerMoves.Add(false);
                }
                else 
                {
                    p2.Score += score4;
                    p5.Score += score4;
                    p2.PartnerMoves.Add(false);
                    p5.PartnerMoves.Add(false);
                }
            }

            Console.WriteLine("Player2 score: " + p2.Score);
            Console.WriteLine("Player5 score: " + p5.Score);
        }
        public static void Run8()
        {
            int rounds = 30; 
            int score1 = 10; 
            int score2 = 15; 
            int score3 = -10; 
            int score4 = 0; 
                            
            Player p3 = new Player(new StrategyGoodTillOpponentGoesBad());
            Player p4 = new Player(new StrategyBadTillOpponentGoesGood());
            for (int i = 0; i < rounds; i++)
            {
                bool move3 = p3.GetNextMove();
                bool move4 = p4.GetNextMove();

                if (move3 && move4) 
                {
                    p3.Score += score1;
                    p4.Score += score1;
                    p3.PartnerMoves.Add(true);
                    p4.PartnerMoves.Add(true);
                }
                else if (move3) 
                {
                    p3.Score += score3;
                    p4.Score += score2;
                    p3.PartnerMoves.Add(false);
                    p4.PartnerMoves.Add(true);
                }
                else if (move4)
                {
                    p3.Score += score2;
                    p4.Score += score3;
                    p3.PartnerMoves.Add(true);
                    p4.PartnerMoves.Add(false);
                }
                else
                {
                    p3.Score += score4;
                    p4.Score += score4;
                    p3.PartnerMoves.Add(false);
                    p4.PartnerMoves.Add(false);
                }
            }

            Console.WriteLine("Player3 score: " + p3.Score);
            Console.WriteLine("Player4 score: " + p4.Score);
        }
        public static void Run9()
        {
            int rounds = 30; 
            int score1 = 10; 
            int score2 = 15; 
            int score3 = -10; 
            int score4 = 0; 

            Player p3 = new Player(new StrategyGoodTillOpponentGoesBad());
            Player p5 = new Player(new StrategyTrueFalseAlternately());
            for (int i = 0; i < rounds; i++)
            {
                bool move3 = p3.GetNextMove();
                bool move5 = p5.GetNextMove();

                if (move3 && move5) 
                {
                    p3.Score += score1;
                    p5.Score += score1;
                    p3.PartnerMoves.Add(true);
                    p5.PartnerMoves.Add(true);
                }
                else if (move3) 
                {
                    p3.Score += score3;
                    p5.Score += score2;
                    p3.PartnerMoves.Add(false);
                    p5.PartnerMoves.Add(true);
                }
                else if (move5) 
                {
                    p3.Score += score2;
                    p5.Score += score3;
                    p3.PartnerMoves.Add(true);
                    p5.PartnerMoves.Add(false);
                }
                else 
                {
                    p3.Score += score4;
                    p5.Score += score4;
                    p3.PartnerMoves.Add(false);
                    p5.PartnerMoves.Add(false);
                }
            }

            Console.WriteLine("Player3 score: " + p3.Score);
            Console.WriteLine("Player5 score: " + p5.Score);
        }
        public static void Run10()
        {
            int rounds = 30; 
            int score1 = 10; 
            int score2 = 15; 
            int score3 = -10; 
            int score4 = 0; 
                            
            Player p4 = new Player(new StrategyBadTillOpponentGoesGood());
            Player p5 = new Player(new StrategyTrueFalseAlternately());
            for (int i = 0; i < rounds; i++)
            {
                bool move4 = p4.GetNextMove();
                bool move5 = p5.GetNextMove();

                if (move4 && move5) 
                { 
                    p4.Score += score1;
                    p5.Score += score1;
                    p4.PartnerMoves.Add(true);
                    p5.PartnerMoves.Add(true);
                }
                else if (move4)
                {
                    p4.Score += score3;
                    p5.Score += score2;
                    p4.PartnerMoves.Add(false);
                    p5.PartnerMoves.Add(true);
                }
                else if (move5) 
                {
                    p4.Score += score2;
                    p5.Score += score3;
                    p4.PartnerMoves.Add(true);
                    p5.PartnerMoves.Add(false);
                }
                else 
                {
                    p4.Score += score4;
                    p5.Score += score4;
                    p4.PartnerMoves.Add(false);
                    p5.PartnerMoves.Add(false);
                }
            }

            Console.WriteLine("Player4 score: " + p4.Score);
            Console.WriteLine("Player5 score: " + p5.Score);
        }
    }
}