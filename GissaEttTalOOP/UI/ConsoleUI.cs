using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GissaEttTalOOP.UI
{
    class ConsoleUI
    {
        public static void ShowMessage(string text)
        {
            Console.WriteLine(text);
        }
        public static int GetIntBetween(int min, int max, string text)
        {
            Console.WriteLine(text);
            while(true)
            {
                int selection;
                if (int.TryParse(Console.ReadLine(), out selection)
                    && selection >= min && selection <= max)
                    return selection;
                Console.WriteLine($"Ange ett TAL mellan {min} och {max}");
            }
        }
    }
}
