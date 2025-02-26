using static System.Console;

namespace SIMULATOR
{
    class Simulator
    {
        public static void Memorize()
        {
            var moment = DateTime.Now;
            int time = moment.Hour;
            List<Move> moves = new List<Move>();
            ConsoleKey keyPressed;
            do
            {
                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;
                if (keyPressed == ConsoleKey.W)
                {
                    moves.Add(new MoveNorth());
                    WriteLine("You pressed W");
                }
                if (keyPressed == ConsoleKey.A)
                {
                    moves.Add(new MoveWest());
                    WriteLine("You pressed A");
                }
                if (keyPressed == ConsoleKey.D)
                {
                    moves.Add(new MoveEast());
                    WriteLine("You pressed D");
                }
                if (keyPressed == ConsoleKey.S)
                {
                    moves.Add(new MoveSouth());
                    WriteLine("You pressed S");
                }
                if (keyPressed == ConsoleKey.Backspace)
                {
                    moves.RemoveAt(moves.Count - 1);
                    WriteLine("You removed last element");
                }
                
            } while (keyPressed != ConsoleKey.Enter);
            
            List<string> hints = new List<string>();
            foreach (Move hint in moves)
            {
                WriteLine(hint.Execute(time));
                hints.Add(hint.Execute(time));
            }
            string filePath = "log.txt";
            File.WriteAllLines(filePath, hints);
        }
    }
}