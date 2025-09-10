using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
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

            for (int i = 0; i < 4; i++)
            {
                t1.MoveForward(300);
                t1.TurnRight(90);
            }

            t1.TurnRight(90);
            t1.MoveForward(163);
;
            for (int i = 0; i < 36; i++)
            {
                t1.TurnLeft(10);
                t1.MoveForward(26.167676767676767);

            }
        }
    }
}
