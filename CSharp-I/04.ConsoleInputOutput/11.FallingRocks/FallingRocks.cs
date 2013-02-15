using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.IO;

namespace FallingRocksGame
{
    class FallingRocks
    {
        public partial class NativeMethods
        {
            [System.Runtime.InteropServices.DllImportAttribute("user32.dll", EntryPoint = "BlockInput")]
            [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)]
            public static extern bool BlockInput([System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)] bool fBlockIt);
        } 

        private static Thread rocksThread;
        private static bool runFlag = true;
        private static EventWaitHandle threadSignal = new AutoResetEvent(false);
 
        private static int fieldHeight = 50; // Play field height
        private static int fieldWidth = 130; // Play field width
        private static int rocksDensity = 50; // Symbols density [50...1] the higher the lower the density.
        private static int rocksSpeed = 999; // Rocks speed [999...0] the lower the higher the speed.
        private static int level = 1;

        private static List<ScreenElements> slowRocks = new List<ScreenElements>();
        private static List<ScreenElements> quickRocks = new List<ScreenElements>();
        private static List<ScreenElements> quickerRocks = new List<ScreenElements>();
        private static List<ScreenElements> bonusRocks = new List<ScreenElements>();
        //private static List<ScreenElements> firstLine = new List<ScreenElements>();
        private static Dwarf dwarf;
        public static object syncObject;

        private static StreamReader reader;
        private static StreamWriter writer;
        private static Frames frame;
        private static Menus menu;
        private static ConsoleKeyInfo readKey;
        private static bool soundFlag = true;
        private static bool westWind = false;
        private static bool eastWind = false;
        private static Bombs bombs;
        private static Bombs specialBombs;
        private static ScreenElements[] specialRocks = new ScreenElements[10];
        public static int scoreCounter = 0;
        private static int bullets = 0;
        private static bool shoot = false;
        private static ScreenElements bullet = new ScreenElements(0,0,'|',15);
        private static Random randomX = new Random();
        private static Random randomWind = new Random();
        private static Random randomSymbol = new Random();
        private static Random randomColor = new Random();
        /* ------------------------------------------------------------------------ Main Method ---------------------------------------------------------------------*/
        public static void Main()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(fieldWidth + 1, fieldHeight + 1);
            Console.SetBufferSize(fieldWidth + 1, fieldHeight + 1);

            syncObject = new object();
            menu = new Menus(fieldWidth, fieldHeight);
            menu.Help();
            SetLevel();
            bombs = new Bombs("Bombs: ", 34);
            bombs.SetBombs(0, 41, 6); 
            specialBombs = new Bombs("Special Bombs: ", 54);
            specialBombs.SetBombs(0, 69, 14);

            frame = new Frames(0, 0, ' ', 15);
            
            frame.Print(0, 1, fieldWidth, fieldHeight - 1);
            menu = new Menus(fieldWidth, fieldHeight);
            
            menu.SetTitle("Falling Rocks Game");
            menu.BottomToolbar();
            InitSpecialRocks();
            dwarf = new Dwarf(fieldWidth, fieldHeight);
            SetBullets(10);

            rocksThread = new Thread(ManageRocks);
            rocksThread.Start();

            threadSignal.Set();
            SetWind();
            GetKey();
        }
   
        public static void SetCounter(int counter)
        {
            scoreCounter += counter;
            lock (syncObject)
            {
                Console.SetCursorPosition(fieldWidth - 13, 0);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("SCORE: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0,6}", scoreCounter);
            }
        }

        /* ------------------------------------------------------------------------ Rocks Management ----------------------------------------------------------------*/
        public static void ManageRocks()
        {
            int count = 0;
            while (runFlag)
            {
                SetCounter(10);
                count++;
                if (shoot)
                {
                    bullet.Hide();
                    bullet.MoveUp();
                    if (bullet.positionY > 2)
                    {
                        bullet.Show();
                    }
                    else
                    {
                        bullet.positionX = 0;
                        bullet.positionY = 0;
                        shoot = false;
                    }
                }
                lock (syncObject)
                {
                    Console.SetCursorPosition(fieldWidth - 30, 0);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("({0})", 10 - count);
                }
                
                if (count >= 10)
                {
                    GetSpecialRock();
                    rocksDensity--;
                    SetRocksSpeed(-30);
                    level++;
                    SetLevel();
                    SetWind();
                    count = 0;
                }
                ManageLists(bonusRocks);
                GetNewRocks(quickerRocks, 3);
                ManageLists(quickerRocks);
                Thread.Sleep(rocksSpeed / 5);
                ManageLists(bonusRocks);
                GetNewRocks(quickerRocks, 3);
                ManageLists(quickerRocks);
                Thread.Sleep(rocksSpeed / 5);
                ManageLists(bonusRocks);
                GetNewRocks(quickRocks, 2);
                ManageLists(quickRocks);
                GetNewRocks(slowRocks, 1);
                ManageLists(slowRocks);
                Thread.Sleep(rocksSpeed / 5);
                ManageLists(bonusRocks);
                GetNewRocks(quickerRocks,3);
                ManageLists(quickerRocks);
                Thread.Sleep(rocksSpeed / 5);
                GetNewRocks(quickRocks, 2);
                ManageLists(quickRocks);
                if (soundFlag)
                {
                    //System.Media.SystemSounds.Asterisk.Play();
                    //System.Media.SystemSounds.Beep.Play();
                    //System.Media.SystemSounds.Exclamation.Play();
                    //System.Media.SystemSounds.Hand.Play();
                    //System.Media.SystemSounds.Question.Play();
                    Console.Beep(500, 10);
                }
                
                Thread.Sleep(rocksSpeed / 5);
            }
        }
        private static void ManageLists(List<ScreenElements> RocksList)
        {
            lock (syncObject)
            {
                foreach (ScreenElements rock in RocksList)
                {
                    rock.Hide();
                    rock.MoveDown();
                    if (westWind)
                    {
                        rock.MoveRight(fieldWidth);
                    }
                    if (eastWind)
                    {
                        rock.MoveLeft(fieldWidth);
                    }
                    if (rock.positionX == dwarf.GetPositionX() && rock.positionY == dwarf.GetPositionY())
                    {
                        Collision(rock);
                    }
                    if (rock.positionX == bullet.positionX && rock.positionY == bullet.positionY)
                    {
                        bullet.Hide();
                        bullet.positionX = 0;
                        bullet.positionY = 0;
                        shoot = false;
                        rock.Hide();
                        RocksList.Remove(rock);
                    }
                }
                RocksList.RemoveAll(Rocks => Rocks.positionY >= fieldHeight - 2);
                foreach (ScreenElements rock in RocksList)
                {
                    rock.Show();
                }
            }
        }
        private static void SetRocksSpeed(int speed)
        {
            if (rocksSpeed + speed < 0)
            {
                rocksSpeed = 0;
            }
            else
            {
                if (rocksSpeed + speed > 999)
                {
                    rocksSpeed = 999;
                }
                else
                {
                    rocksSpeed += speed;
                }
            }
        }
        private static void SetRocksDensity(int density)
        {
            if (rocksDensity + density < 0)
            {
                rocksDensity = 0;
            }
            else
            {
                if (rocksDensity + density > 50)
                {
                    rocksDensity = 50;
                }
                else
                {
                    rocksDensity += density;
                }
            }
        }
        private static void GetNewRocks(List<ScreenElements> RocksList, int density)
        {
            int rondomPositionX = 1;
            for (int i = 0; i < fieldWidth / (rocksDensity * density); i++)
            {
                rondomPositionX = randomX.Next(1, fieldWidth);
                while (RocksList.Any(Rocks => Rocks.positionX == rondomPositionX))
                {
                    rondomPositionX = randomX.Next(1, fieldWidth - 2);
                }
                lock (syncObject)
                {
                    RocksList.Add(new ScreenElements(rondomPositionX, 2, '@', randomColor.Next(1, 16)));
                }
            }
        }
        private static void InitSpecialRocks()
        {
            specialRocks[0] = new ScreenElements(1, 1, '*', 10); // Gives Life;
            specialRocks[1] = new ScreenElements(1, 1, '%', 10); // Reduce the speed of the falling rocks;
            specialRocks[2] = new ScreenElements(1, 1, '#', 10); // Bomb - removes rocks and bonuses alike from the screen;
            specialRocks[3] = new ScreenElements(1, 1, '$', 10); // Special bomb - removes only the rocks from the screen;
            specialRocks[4] = new ScreenElements(1, 1, '&', 10); // Reduce density of the falling rocks;
            specialRocks[5] = new ScreenElements(1, 1, '^', 10); // Gives bonus points;
            specialRocks[6] = new ScreenElements(1, 1, '.', 10); // The player can shoot the rocks;
            specialRocks[7] = new ScreenElements(1, 1, '!', 12); // Increase the density of the rocks;
            specialRocks[8] = new ScreenElements(1, 1, '+', 12); // Increase the speed of the falling rocks;
            specialRocks[9] = new ScreenElements(1, 1, ';', 12);  // Instant kill - the player is killed instantly;
        }
        private static void GetSpecialRock()
        {
            int rondomPositionX = 0;
                rondomPositionX = randomX.Next(1, fieldWidth);
                int randSymbol = randomSymbol.Next(0, 10);
                bonusRocks.Add(new ScreenElements(rondomPositionX, 2, specialRocks[randSymbol].value, specialRocks[randSymbol].color));
        }
        /* ---------------------------------------------------------------- Keyboard Input Management ----------------------------------------------------------- */   
        private static void GetKey()
        {
            while (runFlag)
            {
                readKey = Console.ReadKey(true);
                switch (readKey.KeyChar)
                {
                    case 'p': 
                    case 'P':
                        menu.Pause(); break;
                    case 's':
                    case 'S':
                        SoundControl(); break;
                    case 'l':
                    case 'L':
                        menu.Legend(); break;

                    default:
                        break;
                }
                if (readKey.Key == ConsoleKey.Escape)
	            {
                    menu.Quit();
	            }
                if (readKey.Key == ConsoleKey.F1)
                {
                    menu.Help();
                }
                if (readKey.Key == ConsoleKey.B)
                {
                    if (bombs.GetCount() > 0)
                    {
                        Explode(1, 41, 6);
                    }
                }
                if (readKey.Key == ConsoleKey.C)
                {
                    if (specialBombs.GetCount() > 0)
                    {
                        Explode(2, 69, 14);
                    }
                }
                if (readKey.Key == ConsoleKey.LeftArrow)
                {
                    lock (syncObject)
                    {
                        dwarf.MoveLeft();
                    }
                }
                if (readKey.Key == ConsoleKey.RightArrow) 
                {
                    lock (syncObject)
                    {
                        dwarf.MoveRight();
                    }
                }
                if (readKey.Key == ConsoleKey.Spacebar)
                {
                    if (bullets > 0)
                    {
                        bullet.positionX = dwarf.GetPositionX();
                        bullet.positionY = dwarf.GetPositionY() - 1;
                        bullet.Show();
                        SetBullets(-1);
                        shoot = true;
                    }
                }
            }
        }
      
        private static void SoundControl()
        {
            if (soundFlag)
            {
                soundFlag = false;
            }
            else
            {
                soundFlag = true; 
            }
        }

        private static void Collision(ScreenElements rock)
        {
            switch (rock.value)
            {
                case '*': dwarf.IncreaseLives(); break;
                case '#': bombs.SetBombs(1, 41, 6); break;
                case '@': dwarf.DecreaseLives(); break;
                case '%': SetRocksSpeed(100); break;
                case '$': specialBombs.SetBombs(1, 69, 15); break;
                case '+': SetRocksSpeed(-100); break;
                case '&': SetRocksDensity(-3); break;
                case '!': SetRocksDensity(3); break;
                case ';': GameOver(); break;
                case '^': SetCounter(100); break;
                case '.': SetBullets(10); break;

                default: break;
            }       
        }

        private static void SetBullets(int newBullets)
        {
            bullets += newBullets;
            if (bullets > 99)
            {
                bullets = 99;
            }
            if (bullets < 0)
            {
                bullets = 0;
            }
            lock (syncObject)
            {
                Console.SetCursorPosition(82, 0);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Bullets: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0,2}", bullets);
            }
        }

        private static void Shoot()
        {
            shoot = true;
        }

        private static void Explode(int bombType, int position, int color)
        {
            System.Media.SystemSounds.Beep.Play();
            lock (syncObject)
            {
                foreach (ScreenElements rock in slowRocks)
                {
                    rock.Hide();
                }
                slowRocks.Clear();
                foreach (ScreenElements rock in quickRocks)
                {
                    rock.Hide();
                }
                quickRocks.Clear();
                foreach (ScreenElements rock in quickerRocks)
                {
                    rock.Hide();
                }
                quickerRocks.Clear();
                if (bombType == 1)
                {
                    bombs.SetBombs(-1, position, color);
                }
                else
                {
                    specialBombs.SetBombs(-1, position, color);
                    rocksSpeed += 100;
                    rocksDensity += 10;
                }
            }
        }

        private static void SetLevel()
        {
            Console.SetCursorPosition(fieldWidth - 23, 0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("LEVEL: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("{0,2}", level);
        }

        private static void SetWind()
        {
            int wind = randomWind.Next(1, 4);
            lock (syncObject)
            {
                Console.SetCursorPosition(fieldWidth - 27, 0);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("(");
                if (wind == 1)
                {
                    westWind = false;
                    eastWind = false;
                    Console.Write("-");
                }
                if (wind == 2)
                {
                    westWind = true;
                    eastWind = false;
                    Console.Write("W");
                }
                if (wind == 3)
                {
                    westWind = false;
                    eastWind = true;
                    Console.Write("E");
                }
                Console.Write(")");
            }
        }
       
        protected internal static void GameOver() // to be finished
        {
            runFlag = false;
            int height = -11;
            Console.Clear();
            Console.Beep(1000, 1000);
            Console.ForegroundColor = ConsoleColor.Red;
           // Console.WriteLine("Your final score is: {0}", scoreCounter);

            try
            {
                reader = new StreamReader("HighScore.txt");
            }
            catch (FileNotFoundException)
            {
                writer = new StreamWriter("HighScore.txt");
                using (writer)
                {
                    menu.Write(writer);
                }
                reader = new StreamReader("HighScore.txt");
            }
            string line = reader.ReadLine();
            Console.SetCursorPosition(fieldWidth / 2 - 6, fieldHeight / 2 + height);
            while (line != null)
            {
                Console.Write(line);
                height++;
                Console.SetCursorPosition(fieldWidth / 2 - 26, fieldHeight / 2 + height);
                line = reader.ReadLine();
            }
            reader.Close();

            rocksThread.Join();
        }
    }
}