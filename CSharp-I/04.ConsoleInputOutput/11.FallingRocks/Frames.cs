using System;

namespace FallingRocksGame
{
    public class Frames : ScreenElements
    {
        private int startX;
        private int startY;
        private int endX;
        private int endY;
        
        public Frames() {}
        public Frames(int startX, int startY, int endX, int endY)
        {
            this.startX = startX;
            this.startY = startY;
            this.endX = endX;
            this.endY = endY;
        }
        public void Print(int startX, int startY, int endX, int endY)
        {
            this.value = '║';
            for (int i = startY; i < endY; i++)
            {
                this.ShowAt(startX, i);
                this.ShowAt(endX, i);
            }
            this.value = '═';
            for (int i = startX + 1; i < endX; i++)
            {
                this.ShowAt(i, startY);
                this.ShowAt(i, endY);
            }
            this.ShowAtSymbol(startX, startY, '╔');
            this.ShowAtSymbol(startX, endY, '╚');
            this.ShowAtSymbol(endX, startY, '╗');
            this.ShowAtSymbol(endX, endY, '╝');
            for (int i = startX + 1; i <= endX - 1; i++)
            {
                for (int j = startY + 1; j <= endY - 1; j++)
                {
                    this.ShowAtSymbol(i, j, ' ');
                }
            }
        }
        public void Print()
        {
            this.value = '║';
            for (int i = startY; i < endY; i++)
            {
                this.ShowAt(startX, i);
                this.ShowAt(endX, i);
            }
            this.value = '═';
            for (int i = startX + 1; i < endX; i++)
            {
                this.ShowAt(i, startY);
                this.ShowAt(i, endY);
            }
            this.ShowAtSymbol(startX, startY, '╔');
            this.ShowAtSymbol(startX, endY, '╚');
            this.ShowAtSymbol(endX, startY, '╗');
            this.ShowAtSymbol(endX, endY, '╝');
            for (int i = startX + 1; i <= endX - 1; i++)
            {
                for (int j = startY + 1; j <= endY - 1; j++)
                {
                    this.ShowAtSymbol(i, j, ' ');
                }
            }
        }
        public void Clear(int startX, int startY, int endX, int endY)
        {
            for (int i = startX; i <= endX; i++)
            {
                for (int j = startY; j <= endY; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(' ');
                }
            }
        }
    }
}
