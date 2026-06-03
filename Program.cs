namespace Blackjack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" _______   __         ______    ______   __    __     _____   ______    ______   __    __       ");
            Console.WriteLine("/       \\ /  |       /      \\  /      \\ /  |  /  |   /     | /      \\  /      \\ /  |  /  | ");
            Console.WriteLine("$$$$$$$  |$$ |      /$$$$$$  |/$$$$$$  |$$ | /$$/    $$$$$ |/$$$$$$  |/$$$$$$  |$$ | /$$/       ");
            Console.WriteLine("$$ |__$$ |$$ |      $$ |__$$ |$$ |  $$/ $$ |/$$/        $$ |$$ |__$$ |$$ |  $$/ $$ |/$$/        ");
            Console.WriteLine("$$    $$< $$ |      $$    $$ |$$ |      $$  $$<    __   $$ |$$    $$ |$$ |      $$  $$<         ");
            Console.WriteLine("$$$$$$$  |$$ |      $$$$$$$$ |$$ |   __ $$$$$  \\  /  |  $$ |$$$$$$$$ |$$ |   __ $$$$$  \\      ");
            Console.WriteLine("$$ |__$$ |$$ |_____ $$ |  $$ |$$ \\__/  |$$ |$$  \\ $$ \\__$$ |$$ |  $$ |$$ \\__/  |$$ |$$  \\  ");
            Console.WriteLine("$$    $$/ $$       |$$ |  $$ |$$    $$/ $$ | $$  |$$    $$/ $$ |  $$ |$$    $$/ $$ | $$  |      ");
            Console.WriteLine("$$$$$$$/  $$$$$$$$/ $$/   $$/  $$$$$$/  $$/   $$/  $$$$$$/  $$/   $$/  $$$$$$/  $$/   $$/       ");
            Console.WriteLine("\n");
            Console.ResetColor();

            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine("♠ ♥ A SIMPLE GAME BY CSABA BUJKO ♣ ♦\n");
            Console.ResetColor();
            
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Wanna play? Y/N: ");
                string choice = Console.ReadLine() ?? "";
                if (choice == "Y" || choice == "y") { game.Start(); return; }
                else if (choice == "N" || choice == "n") { Console.WriteLine("Good bye!"); Console.ResetColor(); return; }
                else Console.WriteLine("I don't understand!");
                Console.ResetColor();
            }
        }
    }
}
