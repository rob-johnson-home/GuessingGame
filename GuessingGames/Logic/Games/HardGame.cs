using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGames.Logic.Games
{
    class HardGame : GuessingGame
    {
        public HardGame(int high = 1000, int low = 1, int guesses = 4) : base(high, low, guesses)
        {
            this.Title = "Hard - guess a number from 1 - 1000";
        }

    }
}
