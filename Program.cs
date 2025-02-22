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
            int percentFullBar = 100;
            char symbolEmpty = ' ';
            double valueColorBar = (maxValue / percentFullBar) * value;
            double valueEmptyBar = maxValue - valueColorBar;

            string Bar = FillPartBar(valueColorBar, symbol);
            Bar += FillPartBar(valueEmptyBar, symbolEmpty);

            Console.SetCursorPosition(0, positionCursor);
            Console.Write('[');
            Console.Write(Bar);
            Console.Write(']');
            Console.Write($"- {valueColorBar}");
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
