using System;

namespace FallingRocksGame
{
    class Dwarf : ScreenElements
    {
        private ScreenElements leftBracket;
        private ScreenElements rightBracket;
        private ScreenElements dwarf;
        private int dwarfLives;
        private int fieldWidth;

        public Dwarf(int fieldWidth, int fieldHeight)
        {
            leftBracket = new ScreenElements(fieldWidth / 2 - 1, fieldHeight - 2, '(', 15);
            dwarf = new ScreenElements(fieldWidth / 2, fieldHeight - 2, 'O', 15);
            rightBracket = new ScreenElements(fieldWidth / 2 + 1, fieldHeight - 2, ')', 15);
            leftBracket.Show();
            dwarf.Show();
            rightBracket.Show();
            this.fieldWidth = fieldWidth;
            this.dwarfLives = 3;
            this.ShowLives();
        }
        public new void MoveLeft()
        {
            if (leftBracket.positionX > 1)
            {
                leftBracket.MoveLeft();
                dwarf.MoveLeft();
                rightBracket.Hide();
                rightBracket.MoveLeft();
                leftBracket.Show();
                dwarf.Show();
                rightBracket.Show();
            }
        }
        public new void MoveRight()
        {
            if (rightBracket.positionX < fieldWidth - 1)
            {
                rightBracket.MoveRight();
                dwarf.MoveRight();
                leftBracket.Hide();
                leftBracket.MoveRight();
                rightBracket.Show();
                dwarf.Show();
                leftBracket.Show();
            }
        }
        public bool IncreaseLives()
        {
            if (dwarfLives < 6)
            {
                this.dwarfLives++;
                this.ShowLives();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DecreaseLives()
        {
            if (dwarfLives > 1)
            {
                this.dwarfLives--;
                this.ShowLives();
                return true;
            }
            else
            {
                FallingRocks.GameOver(); // needs to be redone properly
                return false;
            }
        }
        public int GetPositionX()
        {
            return dwarf.positionX;
        }
        public int GetPositionY()
        {
            return dwarf.positionY;
        }
        private void ShowLives()
        {
            Console.SetCursorPosition(1, 0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Lives: ");
            Console.Write("                        ");
            Console.SetCursorPosition(8, 0);
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < this.dwarfLives; i++)
            {
                Console.Write("(O) ");
            }
        }
    }
}

