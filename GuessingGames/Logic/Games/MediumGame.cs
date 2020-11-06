using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGames.Logic.Games
{
    class MediumGame : GuessingGame
    {
        public MediumGame(int high = 100, int low = 1, int guesses = 5) : base(high, low, guesses)
        {
            this.Title = "Hard - guess a number from 1 - 100";
        }
    }
}
