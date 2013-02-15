using System;
using System.IO;

namespace FallingRocksGame
{
    class Menus : Frames
    {
        private int fieldWidth;
        private int fieldHeight;

        public Menus(int fieldWidth, int fieldHeight)
        {
            this.fieldWidth = fieldWidth;
            this.fieldHeight = fieldHeight;
        }
        public void Pause()
        {
            ConsoleKeyInfo readKey;
            int x = fieldWidth / 2;
            int y = fieldHeight / 2;
            lock (FallingRocks.syncObject)
            {
                this.Print(x - 20, y - 2, x + 20, y + 2);
                Console.SetCursorPosition(x - 18, y);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Game paused press \"P\" to continue...");
                do
                {
                    readKey = Console.ReadKey(true);
                } while (!(readKey.KeyChar == 'p' || readKey.KeyChar == 'P'));
                this.Clear(x - 20, y - 2, x + 20, y + 2);
            }
        }
        public void Help()
        {
            int x = fieldWidth / 2;
            int y = fieldHeight / 2;
            lock (FallingRocks.syncObject)
            {
                this.Print(x - 40, y - 10, x + 45, y + 10);
                WriteAt(x - 20, y - 9, " Welcome to \"Falling Rocks\" Game.", 15);
                WriteAt(x - 38, y - 5, " The goal of the game is to sustain on the field as long as possible.", 15);
                WriteAt(x - 38, y - 4, " Be aware of the falling rocks, they will harm you.", 15);
                WriteAt(x - 38, y - 3, " Also watch out for the special rocks they will give you bonuses.", 15);
                WriteAt(x - 38, y - 2, " Be aware though the green are friendly, but the red are evil.", 15);
                WriteAt(x - 38, y - 1, " If you see yourselve in dire situation use bombs, they will make space.", 15);
                WriteAt(x - 38, y - 0, " The special bombs are even better because they will reduce the speed.", 15);
                WriteAt(x - 38, y + 1, " Use the arrows <- and -> to move and avoid rocks.", 15);
                WriteAt(x - 38, y + 2, " Use \"B\" and \"C\" to release bombs and special bombs respectively.", 15);
                WriteAt(x - 38, y + 3, " Make as much points as possible.", 15);
                WriteAt(x - 38, y + 5, " Good luck and have fun.", 15);
                WriteAt(x - 20, y + 9, "Press any key to continue... ", 12);
                ConsoleKeyInfo readKey = Console.ReadKey(true);
                this.Clear(x - 40, y - 10, x + 45, y + 10);
            }
        }
        public void BottomToolbar()
        {
            Console.SetCursorPosition(1, fieldHeight);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("S");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" - Sound ON/OFF;");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" L");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" - Legend;");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" P");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" - Pause;");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" B");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" - Bomb;");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" C");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" - Special bomb;");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" Esc");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" - Quit;");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" F1");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" - Help;");
            Console.SetCursorPosition(fieldWidth - 25, fieldHeight);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("TELERIK ACADEMY 2012/2013");
        }
        public void SetTitle(string title)
        {
            string titleString = "";
            for (int i = 0; i < fieldWidth; i++)
            {
                titleString += " ";
            }
            Console.Title = titleString;
            Console.Title = Console.Title.Insert((Console.WindowWidth - 10), title);
        }
        public void Quit()
        {
            ConsoleKeyInfo readKey;
            int x = fieldWidth / 2;
            int y = fieldHeight / 2;
            lock (FallingRocks.syncObject)
            {
                this.Print(x - 22, y - 2, x + 22, y + 2);
                WriteAt(x - 20, y, "Do you really want to leave the game Y/N? ", 12);
                do
                {
                    readKey = Console.ReadKey(true);
                } while (!(readKey.KeyChar == 'y' || readKey.KeyChar == 'Y' || readKey.KeyChar == 'n' || readKey.KeyChar == 'N'));
                if (readKey.KeyChar == 'n' || readKey.KeyChar == 'N')
                {
                    this.Clear(x - 22, y - 2, x + 22, y + 2);
                }
                else
                {
                    FallingRocks.GameOver();
                }
            }
        }
        public void Legend()
        {
            int x = fieldWidth / 2;
            int y = fieldHeight / 2;
            lock (FallingRocks.syncObject)
            {
                this.Print(x - 42, y - 7, x + 42, y + 10);
                PrintLegendSymbols(10, "*", y - 5);
                PrintLegendText(15, "- Gives Life (max 6);", y - 5);
                PrintLegendSymbols(10, "%", y - 4);
                PrintLegendText(15, "- Reduces the speed of the falling rocks;", y - 4);
                PrintLegendSymbols(10, "#", y - 3);
                PrintLegendText(15, "- The bomb removes rocks from the screen activate (B);", y - 3);
                PrintLegendSymbols(10, "$", y - 2);
                PrintLegendText(15, "- The special bomb removes the rocks and reduces their speed activate (C);", y - 2);
                PrintLegendSymbols(10, "&", y - 1);
                PrintLegendText(15, "- Reduces density of the falling rocks;", y - 1);
                PrintLegendSymbols(10, "^", y);
                PrintLegendText(15, "- Gives bonus points;", y);
                PrintLegendSymbols(10, ".", y + 1);
                PrintLegendText(15, "- The player can shoot the rocks;", y + 1);
                PrintLegendSymbols(12, "!", y + 3);
                PrintLegendText(15, "- Increase the density of the rocks;", y + 3);
                PrintLegendSymbols(12, "+", y + 4);
                PrintLegendText(15, "- Increase the speed of the falling rocks;", y + 4);
                PrintLegendSymbols(12, "@", y + 5);
                PrintLegendText(15, "- Takes one's players lives;", y + 5);
                PrintLegendSymbols(12, ";", fieldHeight / 2 + 6);
                PrintLegendText(15, "- Instant kill - the player is killed instantly;", y + 6);
                PrintLegendText(15, "  Press any key to continue...", y + 9);
                ConsoleKeyInfo readKey = Console.ReadKey(true);
                this.Clear(x - 42, y - 7, x + 42, y + 10);
            }
        }
        private void PrintLegendSymbols(int color, string text, int height)
        {
            Console.SetCursorPosition(fieldWidth / 2 - 38, height);
            Console.ForegroundColor = (ConsoleColor)color;
            Console.Write(text);
        }
        private void PrintLegendText(int color, string text, int height)
        {
            Console.SetCursorPosition(fieldWidth / 2 - 35, height);
            Console.ForegroundColor = (ConsoleColor)color;
            Console.Write(text);
        }
        private void WriteAt(int x, int y, string text, int color)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = (ConsoleColor)color;
            Console.Write(text);
        }
        public void Write(StreamWriter writer)
        {
            WriteFile(writer, "TOP 10 SCORE");
            WriteFile(writer, "1.  George Stoikov..........................   10000");
            WriteFile(writer, "2.  Vladimir Enchev.........................    5000");
            WriteFile(writer, "3.  Andrei Mladenov.........................    1000");
            WriteFile(writer, "4.  Nikolai Aleksiev........................     500");
            WriteFile(writer, "5.  ........................................        ");
            WriteFile(writer, "6.  ........................................        ");
            WriteFile(writer, "7.  ........................................        ");
            WriteFile(writer, "8.  ........................................        ");
            WriteFile(writer, "9.  ........................................        ");
            WriteFile(writer, "10. ........................................        ");
        }
        private void WriteFile(StreamWriter writer, string text)
        {
            writer.WriteLine(text);
            writer.WriteLine();
        }
    }
}
