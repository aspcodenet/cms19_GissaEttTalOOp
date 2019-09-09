using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GissaEttTalOOP
{
    //class Person
    //{
    //    DateTime birthDate;
    //    string Name;
    //    public void SetName(string name)
    //    {
    //        Name = name;
    //    }
    //    public Person(DateTime BirthDate)
    //    {
    //        birthDate = BirthDate;
    //    }
    //    public Person(int year, int month, int day)
    //    {
    //        birthDate = new DateTime(year, month, day);
    //    }

    //var kalle = new Person(new DateTime(1950,1,1));
    //kalle.SetName("Kalle");
    //var mia = new Person(new DateTime(1952, 2, 2));
    //mia.SetName("Mia");
    //var josefine = new Person(1953,3,3);
    //josefine.SetName("Josefine");


    //}
    class Program
    {
        static void Main(string[] args)
        {
            int min = UI.ConsoleUI.GetIntBetween(1, 10, "Ange minsta värde i spelet");
            int max = UI.ConsoleUI.GetIntBetween(100, 1000, "Ange högsta värde i spelet");

            var settings = new Game.Settings(min,max);

            var gameEngine = new Game.GameEngine(settings);

            gameEngine.Run();

        }
    }
}
