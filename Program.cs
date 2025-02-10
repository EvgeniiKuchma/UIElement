using System;

namespace UIElement
{
    internal class Program
    {
        static void DrawBar(int value, int maxValue, int positionCursor, char symbol, ConsoleColor colorBar)
        {
            ConsoleColor colorDefult = Console.BackgroundColor;
            string bar = "";

            for (int i = 0; i < value; i++)
            {
                bar += " ";
            }

            Console.SetCursorPosition(0, positionCursor);
            Console.Write('[');
            Console.BackgroundColor = colorBar;
            Console.Write(bar);
            Console.BackgroundColor = colorDefult;

            for (int i = value; i < maxValue; i++)
            {
                bar += " ";
            }

            Console.Write(bar);
            Console.Write(']');
        }
        static void Main(string[] args)
        {
            int cursorPositionHealth = 0;
            int cursorPositionMana = 1;
            int health = 10;
            int maxHealth = 20;
            int mana = 15;
            int maxMana = 15;
            ConsoleColor colorHealth = ConsoleColor.Green;
            ConsoleColor colorMana = ConsoleColor.Blue;
            char symbolDrawBar = ' ';

            DrawBar(health, maxHealth, cursorPositionHealth, symbolDrawBar, colorHealth);
            DrawBar(mana, maxMana, cursorPositionMana, symbolDrawBar, colorMana);
        }
    }
}
