//generate a random number between 1 and 100
//ask 2 players to guess the number
//which one who guesses the number first the closest wins
//if both players guess the same number the game is a tie
//ask to play again

public class main
{
    public static void Main()
    {
        int number = new Random().Next(0, 100);
        int guess1 = 0;
        int guess2 = 0;
        int difference1 = 0;
        int difference2 = 0;

        Console.WriteLine("Welcome to the number guessing game!");
        Console.WriteLine("I have a number between 1 and 100, can you guess it?");
        Console.WriteLine("Press enter to start");
        Console.ReadLine();

        while (true)
        {
            Console.WriteLine("Player 1, guess a number between 1 and 100");
            guess1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Player 2, guess a number between 1 and 100");
            guess2 = Convert.ToInt32(Console.ReadLine());

            difference1 = Math.Abs(number - guess1);
            difference2 = Math.Abs(number - guess2);

            if (difference1 == 0)
            {
                Console.WriteLine("Player 1 wins!");
                Console.WriteLine("The number was " + number);
                playagain();
                break;
            }
            else if (difference2 == 0)
            {
                Console.WriteLine("Player 2 wins!");
                Console.WriteLine("The number was " + number);
                playagain();
                break;
            }
            else if (difference1 < difference2)
            {
                Console.WriteLine("Player 1 wins!");
                Console.WriteLine("The number was " + number);
                playagain();
                break;
            }
            else if (difference2 < difference1)
            {
                Console.WriteLine("Player 2 wins!");
                Console.WriteLine("The number was " + number);
                playagain();
                break;
            }
            else
            {
                Console.WriteLine("It's a tie!");
                Console.WriteLine("The number was " + number);
                playagain();
                break;
            }

        }
    }
    public static void playagain()
    {
        Console.WriteLine("Do you want to play again? (y/n)");
        string playAgain = Console.ReadLine();
        if (playAgain == "y")
        {
            Main();
        }
        else
        {
            Console.WriteLine("Thanks for playing!");
            //wait 5 seconds
            Thread.Sleep(2000);
        }
    }
}