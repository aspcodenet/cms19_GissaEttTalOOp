using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GissaEttTalOOP.UI
{
    interface IGameUserInputOutput
    {
        void ShowMessage(string text);
        int GetIntBetween(int min, int max, string text);

    }
}
