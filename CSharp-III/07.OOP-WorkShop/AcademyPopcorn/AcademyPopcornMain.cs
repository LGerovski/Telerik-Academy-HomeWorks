using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow, i));

                engine.AddObject(currBlock);
            }
            for (int i = startCol; i < endCol; i += 2)
            {
                ExplodingBlock currBlock = new ExplodingBlock(new MatrixCoords(startRow + 1, i));

                engine.AddObject(currBlock);
            }
            for (int i = startCol; i < endCol; i++)
            {
                GiftBlock currBlock = new GiftBlock(new MatrixCoords(startRow + 2, i), new char[,] {{'%'}});

                engine.AddObject(currBlock);
            }
            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow + 4, i));

                engine.AddObject(currBlock);
            }
            for (int i = startCol + 5; i < endCol - 5; i++)
            {
                UnpassableBlock currBlock = new UnpassableBlock(new MatrixCoords(startRow + 3, i));

                engine.AddObject(currBlock);
            }

            for (int i = 1; i < WorldRows; i++)
            {
                IndestructibleBlock newIndestructubleBlock = new IndestructibleBlock(new MatrixCoords(i, 0), '║');
                engine.AddObject(newIndestructubleBlock);
                newIndestructubleBlock = new IndestructibleBlock(new MatrixCoords(i, WorldCols - 1), '║');
                engine.AddObject(newIndestructubleBlock);
            }
            for (int i = 1; i < WorldCols - 1; i++)
            {
                IndestructibleBlock newIndestructubleBlock = new IndestructibleBlock(new MatrixCoords(0, i), '═');
                engine.AddObject(newIndestructubleBlock);
                newIndestructubleBlock = new IndestructibleBlock(new MatrixCoords(WorldRows - 1, i), '_');
                engine.AddObject(newIndestructubleBlock);
            }

            UnstoppableBall theBall = new UnstoppableBall(new MatrixCoords(WorldRows / 2, 0),
                new MatrixCoords(-1, 1));

            engine.AddObject(theBall);

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);
            
            engine.AddObject(theRacket);
        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            Engine gameEngine = new Engine(renderer, keyboard, 300);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            Initialize(gameEngine);

            //

            gameEngine.Run();
        }
    }
}
