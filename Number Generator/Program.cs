using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel.Design;

public class Color 
{
    public static ConsoleColor GetRandomConsoleColor()
    {
        //Das Dictionary mit den zufällig generierten Zahlen wurde durch ChatGPT erstellt

            Dictionary<int, ConsoleColor> numberToColor = new Dictionary<int, ConsoleColor>
            {
            { 1, ConsoleColor.DarkBlue },
            { 2, ConsoleColor.DarkGreen },
            { 3, ConsoleColor.DarkCyan },
            { 4, ConsoleColor.DarkRed },
            { 5, ConsoleColor.DarkMagenta },
            { 6, ConsoleColor.DarkYellow },
            { 7, ConsoleColor.Gray },
            { 8, ConsoleColor.DarkGray },
            { 9, ConsoleColor.Blue },
            { 10, ConsoleColor.Green },
            { 11, ConsoleColor.Cyan },
            { 12, ConsoleColor.Red },
            { 13, ConsoleColor.Magenta },
            { 14, ConsoleColor.Yellow },
            { 15, ConsoleColor.White }
            };

            Random rnd = new Random();         
            int randomColorNumber = rnd.Next(1, 15);

            if (numberToColor.TryGetValue(randomColorNumber, out ConsoleColor selectedColor))
            {
                return selectedColor;
            }
            else
            {
            return ConsoleColor.White;
            }
    }
}




public class programm
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Zwischen welchen Zahlen sollte die Nummer generiert werden?");
        int rangeNumber1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("wähle die zweite Zahl");
        int rangeNumber2 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("es wird eine Zahl zwischen " + rangeNumber1 + " und " + rangeNumber2 + " generiert");

        Random rnd = new Random();          //Random Zahl zum raten
        int Geheimzahl = rnd.Next(rangeNumber1, rangeNumber2);

        Console.WriteLine("Gebe nun deinen ersten Rateversuch ab.");

        int guessNumber = Convert.ToInt32(Console.ReadLine());

        bool Neger = true;

        while (Neger)
        {

            if (guessNumber == Geheimzahl)
            {
                ConsoleColor randomColor = Color.GetRandomConsoleColor();
                Console.ForegroundColor = randomColor;

                Console.WriteLine("Du hast die Geheimzahl erraten!");

                Console.ResetColor();

                Neger = false;
            }
            else 
            {
                if (guessNumber < Geheimzahl)
                {
                    ConsoleColor randomColor = Color.GetRandomConsoleColor();
                    Console.ForegroundColor = randomColor;

                    Console.WriteLine("Die Geheimzahl ist grösser als deine Zahl");

                    Console.ResetColor();

                    Neger = false;
                }

                else if (guessNumber > Geheimzahl)
                {
                    ConsoleColor randomColor = Color.GetRandomConsoleColor();
                    Console.ForegroundColor = randomColor;

                    Console.WriteLine("Die Geheimzahl ist kleiner als deine Zahl");

                    Console.ResetColor();

                    Neger = false;
                }










            }
            
        }
       
        
    }
}

