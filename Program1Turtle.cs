using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.TurtleLib;

namespace Turtle22
{
    internal partial class Program
    {
        /// <summary>
        /// Turtle program
        /// </summary>
        static void Main1()
        {
            Turtle t1 = new Turtle();

            //t1.MoveBackward(200);
            t1.SetDelay(200);
            t1.TailDown();

            t1.TurnRight(60);
            t1.MoveForward(500);
            t1.TurnRight(120);
            t1.MoveForward(500);
            t1.TurnRight(120);
            t1.MoveForward(500);
        }
    }
}
