
using GissaEttTalOOP.UI;

namespace GissaEttTalOOP.Game
{
    class GameEngine
    {
        private readonly IGameUserInputOutput ui;

        public GameEngine(Game.Settings settings, IGameUserInputOutput ui)
        {
            Settings = settings;
            this.ui = ui;
        }

        public Settings Settings { get; }


        public void Run()
        {
            bool cont = true;
            while(cont)
            {
                var gameRound = new GameRound(Settings, ui);
                gameRound.Run();

                int selection = ui.GetIntBetween(0,1,"Ange 0 för att fortsätta, 1 för att avsluta");
                if (selection == 1) break;

            }
        }
    }
}
