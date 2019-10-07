using GissaEttTalOOP.UI;
using GetPass;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GissaEttTalOOP
{
     class Program
    {
        class Leverantor
        {
            public string Namn { get; set; }

            public string Adress { get; set; }
        }

        class Produkt
        {
            public string Namn { get; set; }
            public string ProduktId { get; set; }
            public decimal Price { get; set; }
            public List<Leverantor> Leverantorer{ get; set; } 
    }

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            var list = new List<Produkt>();

            //var s = System.IO.File.ReadAllText("..\\..\\produkt.txt");
            //list = JsonConvert.DeserializeObject<List<Produkt>>(s);

            list.Add(new Produkt { Namn="banan", Price=122.2m, ProduktId="321",
                Leverantorer = new List<Leverantor> { new Leverantor { Adress="231312", Namn = "Lev1" } ,
                new Leverantor { Adress="231323423412", Namn = "Lev2" }
                }
            });
            list.Add(new Produkt { Namn = "äpple", Price = 22.2m, ProduktId = "333" });
            list.Add(new Produkt { Namn = "saft", Price = 12.3m, ProduktId = "123" });


            string toSave = JsonConvert.SerializeObject(list);
            System.IO.File.WriteAllText("..\\..\\produkt.txt",toSave);

            log.Debug("Nu startar programmet");

            while (true)
            {
                Console.WriteLine("mata in lösenord för att får köra spelet");
                var password = ConsolePasswordReader.Read();
                if (password == "hemligt") break;
            }
            log.Debug("Nu har lösenordet skrivits in");

            var ui = new ConsoleUI();
            ui.ShowWelcomeScreen();

            try
            {
                int min = ui.GetIntBetween(1, 10, "Ange minsta värde i spelet");
                int max = ui.GetIntBetween(100, 1000, "Ange högsta värde i spelet");
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }

            //var settings = new Game.Settings(min,max);
            //settings.Save(@"..\..\settings.txt");

            //var gameEngine = new Game.GameEngine(settings,ui);

            //gameEngine.Run();

        }
    }
}
