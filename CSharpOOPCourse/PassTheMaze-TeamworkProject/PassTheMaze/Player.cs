using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassTheMaze
{
    public class Player : GameObject
    {
        public new const string CollisionGroupString = "racket";

        public int Width { get; protected set; }

        public Player(MatrixCoords topLeft)
            : base(topLeft, new char[,] { { 'O'} })
        {
            this.Width = 1;
            this.body = GetRacketBody(this.Width);
        }

        char[,] GetRacketBody(int width)
        {
            char[,] body = new char[1, width];

            for (int i = 0; i < width; i++)
            {
                body[0, i] = 'O';
            }

            return body;
        }

        public void MoveLeft()
        {
            this.topLeft.Col--;
        }

        public void MoveRight()
        {
            this.topLeft.Col++;
        }

        public void MoveDown()
        {
            this.topLeft.Row++;
        }

        public void MoveUp()
        {
            this.topLeft.Row--;
        }

        public override void Update()
        {
        }
    }
}
