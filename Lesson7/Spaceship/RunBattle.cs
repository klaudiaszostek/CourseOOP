namespace SPACESHIP
{
    class RunBattle
    {
        public static void Run()
        {
            // prepare spaceships
            SpaceshipArmor s1 = new SpaceshipArmor();
            SpaceshipLaser s2 = new SpaceshipLaser();
            SpaceshipExtraCannon s3 = new SpaceshipExtraCannon();
            SpaceshipMachineLearning s4 = new SpaceshipMachineLearning();
            SpaceshipNanobots s5 = new SpaceshipNanobots();

            //specifically assigned

            /*Spaceship s1 = new SpaceshipArmor();
            Spaceship s2 = new SpaceshipLaser();
            Spaceship s3 = new SpaceshipExtraCannon();
            Spaceship s4 = new SpaceshipMachineLearning();
            Spaceship s5 = new SpaceshipNanobots();

            s1 = new AIDecorator(s1);
            s2 = new CannonDecorator(s2);
            s3 = new ArmorDecorator(s3);
            s4 = new NanobotsDecorator(s4);
            s5 = new LaserDecorator(s5);*/

            List<Spaceship> tournamentList = new List<Spaceship>() { s1, s2, s3, s4, s5 };

            //randomly assigned

            for (int i = 0; i < tournamentList.Count; i++)
            {
                while (true)
                {
                    Random random = new Random();
                    int bonus = random.Next(tournamentList.Count);
                    if (bonus == 0)
                    {
                        if (tournamentList[i] != s1)
                        {
                            tournamentList[i] = new ArmorDecorator(tournamentList[i]);
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (bonus == 1)
                    {
                        if (tournamentList[i] != s2)
                        {
                            tournamentList[i] = new LaserDecorator(tournamentList[i]);
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (bonus == 2)
                    {
                        if (tournamentList[i] != s3)
                        {
                            tournamentList[i] = new CannonDecorator(tournamentList[i]);
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (bonus == 3)
                    {
                        if (tournamentList[i] != s4)
                        {
                            tournamentList[i] = new AIDecorator(tournamentList[i]);
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (bonus == 4)
                    {
                        if (tournamentList[i] != s5)
                        {
                            tournamentList[i] = new NanobotsDecorator(tournamentList[i]);
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                } 
            }

            // run tournament

            for (int i = 0; i < tournamentList.Count; i++)
            {
                for (int j = i + 1; j < tournamentList.Count; j++)
                {
                    // remember original statistics
                    int hp1 = tournamentList[i].Health;
                    int hp2 = tournamentList[j].Health;
                    int at1 = tournamentList[i].Attack;
                    int at2 = tournamentList[j].Attack;
                    // play this round
                    Console.WriteLine();
                    Console.WriteLine(tournamentList[i].Type() + " (" + tournamentList[i].Health + " HP) vs "
                            + tournamentList[j].Type() + " (" + tournamentList[j].Health + " HP)");
                    do
                    {
                        int attack1 = tournamentList[i].GetNextAttack();
                        int attack2 = tournamentList[j].GetNextAttack();
                        tournamentList[j].Health -= attack1;
                        tournamentList[i].Health -= attack2;
                        Console.WriteLine(tournamentList[i].Type() + " (" + tournamentList[i].Health + " HP) vs "
                            + tournamentList[j].Type() + " (" + tournamentList[j].Health + " HP)");
                    } while (tournamentList[j].Health > 0 && tournamentList[i].Health > 0);
                    if (tournamentList[j].Health > tournamentList[i].Health) Console.WriteLine("winner: " + tournamentList[j].Type());
                    else if (tournamentList[i].Health > tournamentList[j].Health) Console.WriteLine("winner: " + tournamentList[i].Type());
                    else Console.WriteLine("draw!");
                    // restore original statistics
                    tournamentList[i].Health = hp1;
                    tournamentList[j].Health = hp2;
                    tournamentList[i].Attack = at1;
                    tournamentList[j].Attack = at2;
                }
            }
        }
    }
}