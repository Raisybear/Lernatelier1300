    
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Number_Guesser
{
    public class numberGeneration
    {
        public static int Range1()
        {
            Console.WriteLine("Den Bereich zur Generation der Geheimzahl kannst du selbst bestimmen.");
            Console.WriteLine("Schreibe die kleinere Zahl zuerst und als zweites die grössere Zahl.");
            Console.WriteLine("Gebe nun die erste Zahl ein und drücke Enter");

            int rangeNumber1 = 0;
            bool loop1 = true;

            while (loop1 == true)
            {

                try
                {
                    rangeNumber1 = Convert.ToInt32(Console.ReadLine());
                    loop1 = false;
                }
                catch
                {
                    Console.WriteLine("Gebe nur zahlen ein ");
                }
            }

            return rangeNumber1;

        }

        public static int Range2(int rangeNumber1)
        {
            
            int rangeNumber2 = 0;
            bool loop2 = true;
            bool loop3 = true;
            Console.WriteLine("Gebe die zweite Zahl ein und drücke Enter");

            while (loop3 == true) 
            {
                
                while (loop2 == true)
                {
                    try
                    {
                        rangeNumber2 = Convert.ToInt32(Console.ReadLine());
                        loop3 = false;
                        loop2 = false;
                    }
                    catch
                    {
                        Console.WriteLine("Gebe nur zahlen ein ");
                    }
                    if (rangeNumber2 < rangeNumber1)
                    {
                        Console.WriteLine("Gebe eine Zahl ein, die grösser ist als die erste Zahl.");
                    }
                    else if (rangeNumber2 > rangeNumber1)
                    {
                        loop3 = false;
                        loop2 = false;
                    }
                    

                }

            }
            

            return rangeNumber2;
        }


        public static int Generation(int rangeNumber1, int rangeNumber2)
        {
            int Geheimzahl = 0;

            Console.WriteLine("es wird eine Zahl zwischen " + rangeNumber1 + " und " + rangeNumber2 + " generiert");

            Random rnd = new Random();          //Random Zahl zum raten
            Geheimzahl = rnd.Next(rangeNumber1, rangeNumber2);

            return Geheimzahl;

        }
    }
}
