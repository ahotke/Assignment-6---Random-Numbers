namespace Assignment_6___Random_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guess;

            Console.WriteLine("Let's play a game!");
            Console.WriteLine("I chose a number between 1 and 10, can you guess it?");
            Console.Write("Your guess: ");
            Int32.TryParse(Console.ReadLine(), out guess);
            if (guess == secretNumber)
                Console.WriteLine("You guessed my secret number!");
            else if (guess > secretNumber)
                Console.WriteLine("Your guess is too high! My number was " + secretNumber);
            else if (guess < secretNumber)
                Console.WriteLine("Your guess is too low! My number was " + secretNumber);
            Console.WriteLine();
        }
    }
}
