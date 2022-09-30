using System;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(1, 20);
            bool outOfGuesses = false;
            int guess = 0;
            int guessCount = 0;
            int guesslim = 4;            
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");                       
            while (guess != number && !outOfGuesses)
            {
                guess = int.Parse(Console.ReadLine());
                if (guessCount < guesslim)
                {
                    if (guess < number)
                    {
                        Console.WriteLine("Tyvärr du gissade för lågt!");
                    }
                    else if (guess > number)
                    {
                        Console.WriteLine("Tyvärr du gissade för högt!");
                    }
                guessCount++;
                }
                else if (guessCount == guesslim && guess != number)
                {
                    outOfGuesses = true;
                    Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök!");
                }
            check(guess, number);
            }                   
        }
        static void check(int num1, int num2)
        {
            while (num1 == num2)
            {
                Console.WriteLine("Woho! Du gjorde det!");
                break;
            }    
        }        
    }
}
