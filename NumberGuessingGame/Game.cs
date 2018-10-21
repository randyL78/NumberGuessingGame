using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Round round = new Round();
            
            Console.WriteLine(round.CheckAnswer(14));
            Console.WriteLine("You have made " + round.Guesses + " guess(es) so far");
            if (round.HasWon)
                Console.WriteLine("Congratulations, you won!");
            


        }
    }
}