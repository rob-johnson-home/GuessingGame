using GuessingGames.Logic.Games;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGames.UI
{
    public partial class Game : Form
    {

        private GameFactory _gameFactory;
        private GuessingGame _game;



        public Game()
        {
            InitializeComponent();
            _gameFactory = new GameFactory();
            PopulateGamesList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var gameType = lbGamesList.SelectedItem as string;
            _game = _gameFactory.NewGame(gameType);
            lbGameType.Text = _game.Title;

            // start playing!
            _game.GenerateNumber();
        }

        private void PopulateGamesList()
        {
            var availableGames = _gameFactory.ListGames();
            foreach (var game in availableGames)
            {
                lbGamesList.Items.Add(game.Name);
            }
        }

        private void tbGuess_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Return) {
                return;
            }
            if (_game == null)
            {
                MessageBox.Show("Choose a game first");
                return;
            }

            if (_game.gameOver)
            {
                MessageBox.Show("that game is over, choose another");
                return;
            }

            int guess;
            if (int.TryParse(tbGuess.Text, out guess))
            {
                var yn = _game.GuessWithHint(guess);
                if (yn == GuessingGame.Hint.Correct)
                {
                    lbResult.Text = "Correct!!";
                    
                    _game.gameOver = true;
                }
                if (yn == GuessingGame.Hint.TooHigh)
                {
                    lbResult.Text = "Too High!!";
                }
                if (yn == GuessingGame.Hint.TooLow)
                {
                    lbResult.Text = "Too Low!!";
                }
                lbGuessesRemaining.Text = _game.RemainingGuesses().ToString();
            }
        }
    }
}
