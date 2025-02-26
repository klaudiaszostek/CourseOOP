# 7 Composites and decorators

You have: the folder containing the code of the Spaceship class and five classes inheriting from it, representing different types of spaceships. Additionally, the folder also includes an auxiliary class RunBattle equipped with a static Run( ) method, which allows you to play a tournament between ships on a "round robin" basis. 
Please extend the code of this program with the following elements:
- An abstract decorator inheriting from Spaceship and containing a Spaceship class object inside it.
- Five specific decorators inheriting from the abstract decorator and corresponding in their operation to five types of ships - so that using the decorator it is possible to combine any two bonuses, e.g. armor with AI calibration.
- The RunBattle class should be modified (possibly write a new one or add a new method) so that it allows you to play a tournament between ships having two bonuses at once. The tournament participants can be chosen arbitrarily, but there must be at least five of them.


# Result

spaceship-armor with bonus laser (300 HP) vs spaceship-laser with bonus cannon (300 HP)
spaceship-armor with bonus laser (100 HP) vs spaceship-laser with bonus cannon (150 HP)
spaceship-armor with bonus laser (-100 HP) vs spaceship-laser with bonus cannon (0 HP)
winner: spaceship-laser with bonus cannon

spaceship-armor with bonus laser (300 HP) vs spaceship-cannon with bonus AI (300 HP)
spaceship-armor with bonus laser (175 HP) vs spaceship-cannon with bonus AI (150 HP)
spaceship-armor with bonus laser (25 HP) vs spaceship-cannon with bonus AI (0 HP)
winner: spaceship-armor with bonus laser

spaceship-armor with bonus laser (300 HP) vs spaceship-AI with bonus cannon (300 HP)
spaceship-armor with bonus laser (200 HP) vs spaceship-AI with bonus cannon (150 HP)
spaceship-armor with bonus laser (100 HP) vs spaceship-AI with bonus cannon (0 HP)
winner: spaceship-armor with bonus laser

spaceship-armor with bonus laser (300 HP) vs spaceship-nanobots with bonus AI (300 HP)
spaceship-armor with bonus laser (175 HP) vs spaceship-nanobots with bonus AI (150 HP)
spaceship-armor with bonus laser (25 HP) vs spaceship-nanobots with bonus AI (0 HP)
winner: spaceship-armor with bonus laser

spaceship-laser with bonus cannon (300 HP) vs spaceship-cannon with bonus AI (300 HP)
spaceship-laser with bonus cannon (175 HP) vs spaceship-cannon with bonus AI (100 HP)
spaceship-laser with bonus cannon (25 HP) vs spaceship-cannon with bonus AI (0 HP)
winner: spaceship-laser with bonus cannon

spaceship-laser with bonus cannon (300 HP) vs spaceship-AI with bonus cannon (300 HP)
spaceship-laser with bonus cannon (200 HP) vs spaceship-AI with bonus cannon (100 HP)
spaceship-laser with bonus cannon (0 HP) vs spaceship-AI with bonus cannon (-100 HP)
winner: spaceship-laser with bonus cannon

spaceship-laser with bonus cannon (300 HP) vs spaceship-nanobots with bonus AI (300 HP)
spaceship-laser with bonus cannon (175 HP) vs spaceship-nanobots with bonus AI (200 HP)
spaceship-laser with bonus cannon (25 HP) vs spaceship-nanobots with bonus AI (0 HP)
winner: spaceship-laser with bonus cannon

spaceship-cannon with bonus AI (300 HP) vs spaceship-AI with bonus cannon (300 HP)
spaceship-cannon with bonus AI (200 HP) vs spaceship-AI with bonus cannon (175 HP)
spaceship-cannon with bonus AI (100 HP) vs spaceship-AI with bonus cannon (25 HP)
spaceship-cannon with bonus AI (0 HP) vs spaceship-AI with bonus cannon (-150 HP)
winner: spaceship-cannon with bonus AI

spaceship-cannon with bonus AI (300 HP) vs spaceship-nanobots with bonus AI (300 HP)
spaceship-cannon with bonus AI (175 HP) vs spaceship-nanobots with bonus AI (175 HP)
spaceship-cannon with bonus AI (25 HP) vs spaceship-nanobots with bonus AI (25 HP)
spaceship-cannon with bonus AI (-150 HP) vs spaceship-nanobots with bonus AI (-150 HP)
draw!

spaceship-AI with bonus cannon (300 HP) vs spaceship-nanobots with bonus AI (300 HP)
spaceship-AI with bonus cannon (175 HP) vs spaceship-nanobots with bonus AI (100 HP)
spaceship-AI with bonus cannon (25 HP) vs spaceship-nanobots with bonus AI (-100 HP)
winner: spaceship-AI with bonus cannon