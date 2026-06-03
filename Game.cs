namespace Blackjack
{
    public class Game
    {
        Deck Deck = new Deck();
        Hand playerHand = new Hand();
        Hand dealerHand = new Hand();

        public bool busted = false;

        public void Start()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("================================");
            Console.WriteLine("           NEW ROUND!           ");
            Console.WriteLine("================================\n");
            Console.ResetColor();

            Console.WriteLine("New round! Place your bets!\n");

            playerHand.Clear();
            dealerHand.Clear();
            
            busted = false;

            Deck.Shuffle();
            playerHand.AddCard(Deck.Deal());
            dealerHand.AddCard(Deck.Deal());
            playerHand.AddCard(Deck.Deal());
            dealerHand.AddCard(Deck.Deal());

            Console.WriteLine("Your hand: ");
            Console.WriteLine(playerHand);
            Console.WriteLine($"Total: {playerHand.GetTotal()}\n");
            Console.WriteLine($"Dealer shows: {dealerHand.GetCard(0)}\n");
            
            if (playerHand.GetTotal() == 21) 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Congratulations! You win!\n");
                Console.ResetColor();

                GameOver();
                return;
            }

            PlayerTurn();
        }

        public void PlayerTurn()
        {
            bool playing = true;
            while(playing) 
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Type 'hit' or 'stand': ");
                string choice = Console.ReadLine() ?? "";
                if (choice == "hit")
                {
                    Console.ResetColor();
                    playerHand.AddCard(Deck.Deal());                    
                    Console.WriteLine("\nYour hand: ");
                    Console.WriteLine(playerHand);
                    Console.WriteLine($"Total: {playerHand.GetTotal()}\n");
                    if (playerHand.GetTotal() > 21)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Bust! You lose!\n");
                        Console.ResetColor();

                        playing = false;
                        busted = true;
                    }
                }
                else if (choice == "stand")
                {
                    Console.ResetColor();
                    Console.WriteLine("\nDealer's turn!");
                    playing = false;

                }
                else Console.WriteLine("I don't understand!");
            }
            if (!busted) DealerTurn();
            else GameOver();

        }

        public void DealerTurn()
        {            
            while(dealerHand.GetTotal() < 17)
            {
                dealerHand.AddCard(Deck.Deal());
                Console.WriteLine("Dealer draws.");
            }
            Console.WriteLine("Dealer's hand: ");
            Console.WriteLine(dealerHand);
            Console.WriteLine($"Dealer's total: {dealerHand.GetTotal()}\n");
            if (dealerHand.GetTotal() > 21)
            {
                Console.WriteLine("Bust! The dealer lost!");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Congratulations! You win!\n");
                Console.ResetColor();

                GameOver();
                return;
            }                
            CheckWinner();
        }

        public void CheckWinner()
        {
            //if (dealerHand.GetTotal() > 21 && playerHand.GetTotal() <= 21) Console.WriteLine("You win!");
            //else if (dealerHand.GetTotal() <= 21 && playerHand.GetTotal() > 21) Console.WriteLine("You lose!");

            if (playerHand.GetTotal() > dealerHand.GetTotal()) 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Congratulations! You win!\n");
                Console.ResetColor();
            } 
            else if (dealerHand.GetTotal() > playerHand.GetTotal())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You lose!\n");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Incredible! Draw!");
                Console.ResetColor();
            }
            GameOver();
        }

        public void GameOver()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Want to play again? Y/N: ");
                string choice = Console.ReadLine() ?? "";
                if (choice == "Y" || choice == "y") { Start(); return; }
                else if (choice == "N" || choice == "n") { Console.WriteLine("Good bye!"); Console.ResetColor(); return; }
                else Console.WriteLine("I don't understand!");
                Console.ResetColor();
            }
        }
    }
}
