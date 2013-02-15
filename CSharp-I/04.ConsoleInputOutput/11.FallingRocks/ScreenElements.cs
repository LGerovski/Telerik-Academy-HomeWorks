using System;

namespace FallingRocksGame
{
    public class ScreenElements
    {
        public int positionX { get; set; }
        public int positionY { get; set; }
        public char value { get; set; }
        public int color { get; set; }

        public ScreenElements()
        {
            this.color = 15;
        }
        public ScreenElements(int positionX, int positionY, char value, int color)
        {
            this.positionX = positionX;
            this.positionY = positionY;
            this.value = value;
            this.color = color;
        }
        public void Show()
        {
            Console.SetCursorPosition(this.positionX, this.positionY);
            Console.ForegroundColor = (ConsoleColor)this.color;
            Console.Write(this.value);
        }
        public void ShowAt(int positionX, int positionY)
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.ForegroundColor = (ConsoleColor)this.color;
            Console.Write(this.value);
        }
        public void ShowAtSymbol(int positionX, int positionY, char symbol)
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.ForegroundColor = (ConsoleColor)this.color;
            Console.Write(symbol);
        }
        public void Hide()
        {
            Console.SetCursorPosition(this.positionX, this.positionY);
            Console.Write(' ');
        }
        public void MoveDown()
        {
            this.positionY += 1;
        }
        public void MoveUp()
        {
            this.positionY -= 1;
        }
        public void MoveLeft()
        {
            this.positionX -= 1;
        }
        public void MoveLeft(int fieldWidth)
        {
            this.positionX -= 1;
            if (positionX <= 0)
            {
                positionX = fieldWidth - 1;
            }
        }
        public void MoveRight()
        {
            this.positionX += 1;
        }
        public void MoveRight(int fieldWidth)
        {
            this.positionX += 1;
            if (positionX >= fieldWidth)
            {
                positionX = 1;
            }
        }
    }
}
