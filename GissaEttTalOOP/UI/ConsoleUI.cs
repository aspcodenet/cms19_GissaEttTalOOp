using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = Colorful.Console;

namespace GissaEttTalOOP.UI
{
    class ConsoleUI : IGameUserInputOutput
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public void ShowMessage(string text)
        {
            Console.WriteLine(text);
        }
        public int GetIntBetween(int min, int max, string text)
        {
            int n = 0;
            n = 12 / n;

            Console.WriteLine(text, Color.Pink);
            while(true)
            {
                int selection;
                if (int.TryParse(Console.ReadLine(), out selection)
                    && selection >= min && selection <= max)
                    return selection;
                Console.WriteLine($"Ange ett TAL mellan {min} och {max}", Color.Red);
            }
        }

        internal void ShowWelcomeScreen()
        {
            int DA = 244;
            int V = 212;
            int ID = 255;
            Console.WriteAscii("Gissa Ett Tal OOP", Color.FromArgb(DA, V, ID));
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            log.Debug("Nu är welcomescreen visad");
        }
    }
}
