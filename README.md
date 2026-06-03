#BLACKJACK - A simple console application game made in C# (.NET 8)

--GAMEPLAY--
The game creates a deck consisting of 52 cards made from the two enumerators (Suit and Value),
shuffles it, then deals two cards to both the player and the dealer.
The dealer reveals one card, while keeping the other one hidden

The player has the chance to draw a card by typing 'hit', as long as their score does not exceed 21.
Typing in 'stand' ends the round of the player, and the dealer starts drawing until they reach at least 17 points.
Then the dealer reveals their cards.

If the player's starting hand totals 21 points, they win instantly.

--CARD VALUES--
Ace = 11 pts (counts as 1 pts if the total exceeds 21 pts)
Jack, King, Queen = 10 pts
All other cards = face value

--WIN/LOSE CONDITION--
If the player's points exceed 21, they lose instantly.
If the dealer' points exceed 21, but not the player's points, the dealer loses.
Otherwise, whomever has the higher points wins.
If both the player and the dealer have similar points, the game ends in a draw.

--HOW TO RUN--
Clone the respository, open in Visual Studio, then run the project.
