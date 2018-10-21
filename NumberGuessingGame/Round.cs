using System;

namespace NumberGuessingGame
{
    public class Round
    {
        private const int _min = 0;
        private const int _max = 20; 
        private readonly int _answer;
        public bool HasWon { get; private set; }

        public int Guesses { get; private set; } = 0;

        public Round()
        {
            _answer = new Random().Next(_min, _max);
        }

        public string CheckAnswer(int guess)
        {
            Guesses++;

            if (guess < _answer)
            {
                return "Guess was too low";
            } 
            else if (guess > _answer)
            {
                return "Guess was too high";
            }

            HasWon = true;
            return "You are correct!";
        }
        
    }
}