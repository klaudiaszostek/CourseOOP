# 8 Commands and adapters

Please write a walking simulator that will retrieve information from the keyboard about the direction in which the user wants to go. It should have in particular:
- An abstract Move class that will have a public Execute(int currentTime) method.
- Four classes inheriting from the above: MoveNorth, MoveSouth, MoveWest and MoveEast. Each of them should have its own implementation of the Execute method, which will print information on the screen about the direction in which the user is going at a given moment. If the user is moving against the sun (this should be checked based on the time given as currentTime), you should also print information about shielding their eyes or some other reaction.
- A Simulator class that will provide a Memorize( ) method, allowing to remember the user's instructions. The hints should be retrieved as
keys pressed on the keyboard (e.g. W, S, A, D or arrows - the built-in Console.ReadKey method will be useful). In addition, the method should respond to two additional keys: one of them should mean that user made a mistake and wants to delete the last command issued (Backspace), the other should mean acceptance and completion of entering the hints (Enter).
- After accepting the list of commands (but not before!), the Simulator should execute each of them in order and save the memorized sequence to the log.txt file.
