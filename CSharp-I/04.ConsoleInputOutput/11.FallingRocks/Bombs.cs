using System;

namespace FallingRocksGame
{
    class Bombs
    {
        private int count;

        public Bombs(string name, int position)
        {
            count = 3;
            Console.SetCursorPosition(position, 0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(name);
        }
        public int GetCount()
        {
            return count;
        }
        public void SetBombs(int number, int postion, int color)
        {
            count += number;
            if (count <= 3)
            {
                Console.SetCursorPosition(postion, 0);
                Console.Write("            ");
                Console.SetCursorPosition(postion, 0);
                Console.ForegroundColor = (ConsoleColor)color;
                if (count > 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                        Console.Write("(O) ");
                    }
                }
                else
                {
                    count = 0;
                    Console.Write("- ");
                }
            }
            else
            {
                count = 3;
            }
        }
    }
}

