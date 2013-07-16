using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassTheMaze
{
  
   public class Exit : GameObject
   {
       public new const string CollisionGroupString = "exit";
       public Exit(MatrixCoords topLeft)
           : base(topLeft, new char[,] { { '▒' } })
       {

       }

       public override void Update()
       {

       }
   }
  
}
