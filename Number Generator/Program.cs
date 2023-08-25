using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel.Design;
using Number_Generator;

public class programm
{
    public static void Main(string[] args)
    {
        StartGame(numberGeneration.Generation());
    }

    public static void StartGame(int Geheimzahl)
    {

        Console.WriteLine("Gebe nun deinen ersten Rateversuch ab.");

        int loop = 0;

        while (loop == 0)
        {
            int guessNumber;

            try
            {
                guessNumber = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Ungültige Eingabe, verwende nur Zahlen im richtigen Bereich");
                continue;
            }

            while (true)
            {
                if (guessNumber == Geheimzahl)
                {
                    ConsoleColor randomColor = Color.GetRandomConsoleColor();
                    Console.ForegroundColor = randomColor;

                    Console.WriteLine("Du hast die Geheimzahl erraten!");

                    Console.ResetColor();

                    loop++;

                    if (loop >= 1)
                    {
                        Console.WriteLine("Willst du nochmal spielen?");

                        string Antwort = Console.ReadLine();

                        if (Antwort == "Ja")
                        {

                            StartGame(numberGeneration.Generation());
                        }
                        else if (Antwort == "Nein")
                        {
                            break;

                        }

                    }

                }
                else
                {
                    if (guessNumber < Geheimzahl)
                    {
                        ConsoleColor randomColor = Color.GetRandomConsoleColor();
                        Console.ForegroundColor = randomColor;

                        Console.WriteLine("Die Geheimzahl ist grösser als deine Zahl");

                        Console.ResetColor();

                        break;
                    }

                    else if (guessNumber > Geheimzahl)
                    {
                        ConsoleColor randomColor = Color.GetRandomConsoleColor();
                        Console.ForegroundColor = randomColor;

                        Console.WriteLine("Die Geheimzahl ist kleiner als deine Zahl");

                        Console.ResetColor();

                        break;
                    }


                }

            }

        }
 
    }
}

