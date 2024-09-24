namespace Assignment_6___Random_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int guess, secretNumber, min, max;

            // Random numbers
            Console.WriteLine("Please enter a minimum value: ");
            Console.Read();
            Console.WriteLine("Please enter a maximum value: ");
            Console.Read();





            // Better guessing game
            secretNumber = generator.Next(1, 10);
            
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
            else if (guess > 10)
                Console.WriteLine("I said from 1 to 10! That's way too high.");
            else if (guess < 1)
                Console.WriteLine("I said from 1 to 10! That's way too low.");
            Console.WriteLine();
        }
    }
}
