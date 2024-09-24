namespace Assignment_6___Random_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int guess, secretNumber, min, max, num, die1, die2, sum;

            // Random numbers
            Console.WriteLine("Please enter a minimum value, as a whole number: ");
            Int32.TryParse(Console.ReadLine(), out min);
            Console.WriteLine("Please enter a maximum value, as a whole number: ");
            Int32.TryParse(Console.ReadLine(), out max);

            num = generator.Next(min, max);
            Console.WriteLine("The number I randomly picked from that range is " + num);

            Console.WriteLine();
            


            // Better guessing game
            secretNumber = generator.Next(1, 10);
            
            Console.WriteLine("Let's play a game!");
            Console.WriteLine("I chose a number between 1 and 10, can you guess it?");
            Console.Write("Your guess: ");
            Console.WriteLine();
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

            // Roll the dice

            die1 = generator.Next(1, 6);
            die2 = generator.Next(1, 6);
            sum = die1 + die2;

            Console.WriteLine("I rolled two dice. The first was a " + die1 + " and the second was a " + die2);
            Console.WriteLine("Their sum is " + sum);
            Console.ReadLine();
        }
    }
}
