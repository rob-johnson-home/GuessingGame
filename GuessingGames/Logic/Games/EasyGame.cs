using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGames.Logic.Games
{
    class EasyGame : GuessingGame
    {
        public EasyGame(int high = 10, int low = 1, int guesses = 6) : base(high, low, guesses)
        {
            this.Title = "Easy - guess a number from 1 - 10";
        }
    }
}
