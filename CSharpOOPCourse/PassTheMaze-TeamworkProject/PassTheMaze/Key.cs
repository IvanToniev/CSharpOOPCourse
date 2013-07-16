using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassTheMaze
{
     public sealed class Key : GameObject
    {
        public new const string CollisionGroupString = "key";

        private static readonly Key key=new Key(new MatrixCoords(17,40));

        private Key(MatrixCoords topLeft)
            : base(topLeft, new char[,] { { 'ⱡ' } })
        {

        }

        public static Key Instance
        {
            get
            {
                return key;
            }
        } 
        

        public override void Update()
        {

        }
    }
}
