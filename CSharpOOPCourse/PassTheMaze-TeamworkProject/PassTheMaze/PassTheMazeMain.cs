using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassTheMaze
{
    class PassTheMazeMain
    {
        const int WorldRows = 23;
        const int WorldCols = 45;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            int startRow = 1;
            int startCol = 1;
            int endCol = WorldCols - 2;
            int endRow = WorldRows - 1;

            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow, i));
                Block currBlock2 = new Block(new MatrixCoords(WorldRows - 1, i));
                engine.AddObject(currBlock);
                engine.AddObject(currBlock2);
            }

            for (int i = startRow; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(i, startCol));
                Block currBlock2 = new Block(new MatrixCoords(i, endCol));
                engine.AddObject(currBlock);
                engine.AddObject(currBlock2);
            }

            for (int i = startRow; i < endRow; i++)
            {
                for (int j = startCol; j < endCol; j++)
                {
                    if ((i == 19 && j >= 9 && j <= 17) ||
                        (i <= 19 && i >= 10 && j >= 17 && j <= 19) ||
                        (i == 10 && j >= 19 && j <= 26) ||
                        (i == 10 && j >= 29 && j <= 35) ||
                        (i <= 10 && i >= 6 && j >= 35 && j <= 36) ||
                        (i == 6 && j >= startCol && j <= 36) ||
                        (i == 16 && j >= 28 && j <= endCol) ||
                        (i >= 17 && i <= 18 && j == 28) ||
                        (i >= 20 && i <= WorldRows && j == 28)

                        )
                    {
                        Block currBlock = new Block(new MatrixCoords(i, j));
                        engine.AddObject(currBlock);
                    }
                }

            }
            Player theRacket = new Player(new MatrixCoords(WorldRows - 2, WorldCols / 2));

            engine.AddObject(theRacket);

            Exit exit = new Exit(new MatrixCoords(4, 3));
            engine.AddObject(exit);

            Key key = Key.Instance;
            engine.AddObject(key);
        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            Engine gameEngine = new Engine(renderer, keyboard);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {

                gameEngine.MovePlayerLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRight();
            };

            keyboard.OnUpPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerUp();
            };
            keyboard.OnDownPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerDown();
            };
            Initialize(gameEngine);

            //

            gameEngine.Run();
        }
    }
}
