using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GissaEttTalOOP.Game
{
    class Settings
    {
        int min;
        public int Min { get { return min; }
            set {
                if(value > 0)
                    min = value;
            }
        }


        public int Max { get; set; }


        public Settings(int min, int max)
        {
            if (min < 0)
                this.Min = 1;
            this.Min = min;

            this.Max = max;
        }


        internal void Load(string file)
        {
            var lines = System.IO.File.ReadAllLines(file);
            Min = Convert.ToInt32(lines[0]);
            Max = Convert.ToInt32(lines[1]);
        }

        internal void Save(string file)
        {
            var lines = new string[]
            {
                Min.ToString(),
                Max.ToString()
            };
            System.IO.File.WriteAllLines(file,lines);
        }
    }
}
