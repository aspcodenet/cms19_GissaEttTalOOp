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

        public GameRound(Settings settings)
        {
            Settings = settings;
            Guesses = 1;
            CorrectAnswer = random.Next(settings.Min, settings.Max);
        }
        public Settings Settings { get; }

        public void Run()
        {
            UI.ConsoleUI.ShowMessage($"Gissa ett tal mellan {Settings.Min} och {Settings.Max}");

            while(true)
            {
                
                var playerNumber = UI.ConsoleUI.GetIntBetween(
                    Settings.Min,Settings.Max, $"Gissning {Guesses}:");
                if (playerNumber < CorrectAnswer)
                {
                    UI.ConsoleUI.ShowMessage("Talet är större.");
                    Guesses++;
                }
                else if (playerNumber > CorrectAnswer)
                {
                    UI.ConsoleUI.ShowMessage("Talet är mindre.");
                    Guesses++;
                }
                if(playerNumber == CorrectAnswer)
                {
                    UI.ConsoleUI.ShowMessage("Hurra");
                    break;
                }

            }

        }
    }
}
