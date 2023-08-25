using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Generator
{
    public class numberGeneration
    {
        public static int Generation()
        { 

            Console.WriteLine("Zwischen welchen Zahlen sollte die Nummer generiert werden?");
            Console.WriteLine("Gebe die erste Zahl ein und drücke Enter");
            int rangeNumber1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("wähle die zweite Zahl und bestätige diese wie zuvor");
            int rangeNumber2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("es wird eine Zahl zwischen " + rangeNumber1 + " und " + rangeNumber2 + " generiert");

            Random rnd = new Random();          //Random Zahl zum raten
            int Geheimzahl = rnd.Next(rangeNumber1, rangeNumber2);

            return Geheimzahl;

        }
    }
}
