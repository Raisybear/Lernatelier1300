using System;
using System.Text;
using System.Collections.Generic;

internal class programm
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Zwischen welchen Zahlen sollte die Nummer generiert werden?");
        int rangeNumber1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("wähle die zweite Zahl");
        int rangeNumber2 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("es wird eine Zahl zwischen " + rangeNumber1 + " und " + rangeNumber2 + " generiert");

        Random rnd = new Random();          //Random Zahl zum raten
        int Geheimzahl = rnd.Next(1, 100);

        Console.WriteLine("Gebe nun deinen ersten Rateversuch ab.");

        int guessNumber = Convert.ToInt32(Console.ReadLine());

        Random rnd2 = new Random();         //Random Zahl um die Farbe zu verstellen
        int Farbzahl = rnd.Next(1, 100);

        string[] cars = { "DarkBlue", "DarkGreen", "DarkCyan", "DarkRed", "DarkMagenta", "DarkYellow", "Gray", "DarkGrey", "Blue", "Green", "Cyan", "Red", "Magenta", "Yellow", "White" };
        Console.WriteLine(cars[0]);

        if (guessNumber > Geheimzahl)
        {
            Console.WriteLine("Die Geheimzahl ist ist kleiner als deine Zahl");
            Console.ForegroundColor = ConsoleColor.Red;

        }
        else if (guessNumber < Geheimzahl)
        {
            Console.WriteLine("Die Geheimzahl ist ist grösser als deine Zahl");

        }
        else if (guessNumber == Geheimzahl)
        {
            Console.WriteLine("Du hast die Geheimzahl erraten!");

        }
    }

}