
namespace GissaEttTalOOP.Game
{
    class GameEngine
    {
        public GameEngine(Game.Settings settings)
        {
            Settings = settings;
        }

        public Settings Settings { get; }


        public void Run()
        {
            bool cont = true;
            while(cont)
            {
                var gameRound = new GameRound(Settings);
                gameRound.Run();

                int selection = UI.ConsoleUI.GetIntBetween(0,1,"Ange 0 för att fortsätta, 1 för att avsluta");
                if (selection == 1) break;

            }
        }
    }
}
