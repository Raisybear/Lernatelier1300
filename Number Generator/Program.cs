﻿using System;
using System.Media;
using System.Text;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel.Design;
using Number_Guesser;
using Microsoft.VisualBasic;

namespace Number_Guesser
{   
    public class programm
    {
        public static void Main(string[] args)
        {
            StartGame();    
        }

        public static void StartGame()
        {
            int rangeNumber1 = numberGeneration.Range1();
            int rangeNumber2 = numberGeneration.Range2(rangeNumber1);
            int Geheimzahl = numberGeneration.Generation(rangeNumber1, rangeNumber2);

            Console.WriteLine("Gebe nun deinen ersten Rateversuch ab und bestätige mit der Enter Taste.");
            int guessNumber = 0;
            int loop = 0;

            while (loop == 0)
            {
                
                try
                {
                    guessNumber = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Ungültige Eingabe, verwende nur Zahlen um die Zahl zu erraten.");
                    continue;
                }

                while (true)
                {
                    if (guessNumber == Geheimzahl)
                    {
                        ConsoleColor randomColor = Color.GetRandomConsoleColor();
                        Console.ForegroundColor = randomColor;

                        Console.WriteLine("Du hast die Geheimzahl erraten!");

                        //SoundPlayer.sounds();

                        Console.ResetColor();

                        loop++;

                        if (loop >= 1)
                        {
                            Console.WriteLine("Willst du nochmal spielen?");
                            Console.WriteLine("Schreibe Ja oder Nein.");

                            string Antwort;

                            try
                            {
                                Antwort = Console.ReadLine();
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Ungültige Eingabe, Antworte mit Ja oder Nein");
                                continue;
                            }

                            if (Antwort == "Ja")
                            {
                                StartGame();
                            }
                            else if (Antwort == "Nein")
                            {
                                break;
                            }                           
                        }
                    }
                    else
                    {
                        if (guessNumber > rangeNumber2)
                        {
                            Console.WriteLine("Probiere die Zahl in deinem festgelegten Rahmen zu erraten.");
                        }
                        if (guessNumber < rangeNumber1)
                        {
                            Console.WriteLine("Probiere die Zahl in deinem festgelegten Rahmen zu erraten.");
                        }

                        if (guessNumber < Geheimzahl && guessNumber < rangeNumber2 || guessNumber < rangeNumber1)
                        {
                            ConsoleColor randomColor = Color.GetRandomConsoleColor();
                            Console.ForegroundColor = randomColor;

                            Console.WriteLine("Die Geheimzahl ist grösser als deine Zahl");

                            Console.ResetColor();

                            break;
                        }

                        else if (guessNumber > Geheimzahl && guessNumber > rangeNumber2 || guessNumber > rangeNumber1)
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
}

