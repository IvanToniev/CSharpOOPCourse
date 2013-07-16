using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassTheMaze
{
    public class Block:GameObject
    {

        public Block(MatrixCoords topLeft)
            : base(topLeft, new char[,] { { '█' } })
        {

        }

        public override void Update()
        {

        }
    }
}
