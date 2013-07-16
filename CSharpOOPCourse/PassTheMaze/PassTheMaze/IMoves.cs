using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassTheMaze
{
    public interface IMoves
    {
        void MovePlayerLeft();

        void MovePlayerUp();

        void MovePlayerDown();

        void MovePlayerRight();
    }
}
