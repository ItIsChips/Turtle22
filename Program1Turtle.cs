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
            Random rnd = new Random();

            //t1.MoveBackward(200);
            t1.SetDelay(0);
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




            t1.MoveBackward(163);
            for (int i = 0; i < 1000000; i++)
            {
                int doty = rnd.Next(1, 298);
                int dotx = rnd.Next(1, 301);
                t1.TailUp();
                t1.MoveForward(dotx);
                t1.TurnLeft(90);
                t1.MoveForward(doty);
                t1.TailDown();
                t1.MoveForward(5);
                t1.TailUp();
                t1.MoveForward(doty * -1 -5);
                t1.TurnRight(90);
                t1.MoveForward(dotx * -1);


            }




        }
    }
}


//for (int i = 0; i < 20; i++)
//{
//    double dot1 = rnd.Next(1, 4);
//    double dot11 = rnd.Next(1, 4);
//
//    t1.TailUp();
//    t1.MoveBackward(163);
//    t1.TurnLeft(90);
//    t1.MoveForward(dot1 * 100);
//    t1.TurnRight(90);
//    t1.MoveForward(dot11 * 100);
//    t1.TailDown();
//
//   for (int f = 0; f < 36; f++)
//   {
//        t1.TurnLeft(10);
//        t1.MoveForward(2);






//if (turtx > 300) ;
//{
//    t1.TurnRight(90);
//    t1.MoveBackward(100);
//    t1.TurnLeft(90);
//}
//if (turtx < -300) ;
//{
//    t1.TurnRight(90);
//    t1.MoveForward(100);
//    t1.TurnLeft(90);
//}
//if (turty < -300) ;
//{
//    t1.MoveForward(100);
//}
//if (turty > 300) ;
//{
//    t1.MoveBackward(100);
//}