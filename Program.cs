using System;

namespace UIElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cursorPositionHealth = 0;
            int cursorPositionMana = 1;
            double precentFullHealth = 75;
            double maxHealth = 20;
            double precentFullMana = 10;
            double maxMana = 15;
            char symbolDrawBar = '#';

            DrawColorPartBar(precentFullHealth, maxHealth, cursorPositionHealth, symbolDrawBar);
            DrawColorPartBar(precentFullMana, maxMana, cursorPositionMana, symbolDrawBar);
        }
        static void DrawColorPartBar(double value, double maxValue, int positionCursor, char symbol)
        {
            char symbolEmpty = ' ';
            double percentColorBar = (maxValue / 100) * value;
            double percentEmptyBar = maxValue - percentColorBar;

            string Bar = FillPartBar(percentColorBar, symbol);
            Bar += FillPartBar(percentEmptyBar, symbolEmpty);

            Console.SetCursorPosition(0, positionCursor);
            Console.Write('[');
            Console.Write(Bar);
            Console.Write(']');
            Console.Write($"- {percentColorBar}");
        }
        static string FillPartBar(double maxValue, char symbol)
        {
            string bar = "";

            for (int i = 0; i < maxValue; i++)
            {
                bar += symbol;
            }

            return bar;
        }
    }
}
