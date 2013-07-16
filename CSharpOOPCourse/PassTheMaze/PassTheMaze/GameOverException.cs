using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassTheMaze
{
    class GameOverException:ApplicationException
    {
        public GameOverException(string msg)
            : base(msg)
        {
        }
    }
}
