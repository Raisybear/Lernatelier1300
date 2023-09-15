using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel.Design;
namespace Number_Guesser
{
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
}