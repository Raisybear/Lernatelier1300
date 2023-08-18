using System;
using System.Text;
using System.Collections.Generic;

internal class programm
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Zwischen welchen Zahlen sollte die Nummer generiert werden?");
        int rangeNumber1 = Convert.ToInt32(Console.ReadLine());
        int rangeNumber2 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("es wird eine Zahl zwischen " + rangeNumber1 + " und " + rangeNumber2 + " generiert");

        Random rnd = new Random();
        int Geheimzahl = rnd.Next(1, 100);
    }

}