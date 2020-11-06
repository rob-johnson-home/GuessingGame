using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGames.Logic.Games
{
    public abstract class GuessingGame
    {
        private int low;
        private int high;
        private int guesses;
        private int myNumber;
        public string Title = "A Guessing Game";
        public bool gameOver = true;

        public enum Hint
        {
            Correct = 0,
            TooHigh,
            TooLow
        }

        public GuessingGame(int high, int low, int guesses)
        {
            // check all the params make sense just here
            if (high <= low || guesses <= 0)
            {
                //not a proper game
                throw new ApplicationException("Problem with game setup");
            }

            this.high = high;
            this.low = low;
            this.guesses = guesses;
            this.gameOver = false;

        }

        public int RemainingGuesses()
        {
            return guesses;
        }


        public virtual void GenerateNumber()
        {
            var rnd = new Random();
            myNumber = rnd.Next(low, high);
        }

        public virtual Hint GuessWithHint(int playerGuess)
        {
            guesses--;
            if (guesses == 0)
            {
                this.gameOver = true;
            }

            if (myNumber == playerGuess)
            {
                return Hint.Correct;
            }
            else if (myNumber > playerGuess)
            {
                return Hint.TooLow; // too low
            }
            else
            {
                return Hint.TooHigh; // too high
            }

        }
    }
}