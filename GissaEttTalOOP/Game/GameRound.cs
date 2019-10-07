using GissaEttTalOOP.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GissaEttTalOOP.Game
{
    class GameRound
    {
        int Guesses;
        int CorrectAnswer;

        static Random random = new Random();
        private readonly IGameUserInputOutput ui;

        public GameRound(Settings settings, IGameUserInputOutput ui)
        {
            Settings = settings;
            this.ui = ui;
            Guesses = 1;
            CorrectAnswer = random.Next(settings.Min, settings.Max);
        }
        public Settings Settings { get; }

        public void Run()
        {
            ui.ShowMessage($"Gissa ett tal mellan {Settings.Min} och {Settings.Max}");

            while(true)
            {
                
                var playerNumber = ui.GetIntBetween(
                    Settings.Min,Settings.Max, $"Gissning {Guesses}:");
                if (playerNumber < CorrectAnswer)
                {
                    ui.ShowMessage("Talet är större.");
                    Guesses++;
                }
                else if (playerNumber > CorrectAnswer)
                {
                    ui.ShowMessage("Talet är mindre.");
                    Guesses++;
                }
                if(playerNumber == CorrectAnswer)
                {
                    ui.ShowMessage("Hurra");
                    break;
                }

            }

        }
    }
}
