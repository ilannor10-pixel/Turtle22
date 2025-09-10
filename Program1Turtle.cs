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
            t1.SetDelay(1);
            t1.TailDown();
            t1.SetVisible(false);
            t1.TurnLeft(90);
            t1.MoveForward(200);
            t1.TurnRight(120);
            t1.MoveForward(200);
            t1.TurnRight(120);
            t1.MoveForward(200);
            t1.SetTailColor(System.Drawing.Color.Blue);
            t1.TailUp();
            t1.TurnRight(90);
            t1.MoveForward(200);
            t1.TailDown();
            t1.TurnLeft(30);
            t1.MoveForward(200);
            t1.MoveBackward(200);
            t1.TurnRight(60);
            t1.MoveForward(150);
            t1.TailUp();
            t1.MoveForward(50);
            t1.TailDown();
            t1.MoveForward(150);
            t1.TurnLeft(90);
            t1.MoveForward(200);
            t1.TurnLeft(90);
            t1.MoveForward(150);
            t1.TurnLeft(90);
            t1.MoveForward(100);
            t1.TurnLeft(90);
            t1.MoveForward(150);
            t1.SetVisible(false);
            t1.SetTailColor(System.Drawing.Color.IndianRed);
            t1.TailUp();
            t1.TurnRight(90);
            t1.MoveForward(300);
            t1.TailDown();
            for (int i = 0; i < 100; i++)
            {
                t1.MoveForward(15);
                t1.TurnLeft(5);
            }
            t1.TurnRight(300);
            t1.MoveForward(200);

            t1.MoveForward(10);
            t1.SetTailColor(System.Drawing.Color.Purple);


            t1.MoveForward(10);
            t1.SetTailColor(System.Drawing.Color.Purple);

            for (int i = 0; i < 36; i++)
            {
                t1.MoveForward(20);
                t1.TurnLeft(10);
            }
            t1.MoveForward(10);
            t1.SetTailColor(System.Drawing.Color.Purple);

            for (int i = 0; i < 36; i++)
            {
                t1.MoveForward(20);
                t1.TurnLeft(10);
            }
            t1.MoveForward(10);
            t1.SetTailColor(System.Drawing.Color.Purple);

            for (int i = 0; i < 36; i++)
            {
                t1.MoveForward(20);
                t1.TurnLeft(10);
            }

            for (int f = 0; f < 10; f++)
            {
                t1.MoveForward(30);
                t1.SetTailColor(System.Drawing.Color.Teal);

                for (int i = 0; i < 36; i++)
                {
                    t1.MoveForward(30);
                    t1.TurnLeft(10);
                }
            }
            t1.TurnLeft(70);
            t1.MoveForward(100);
            t1.SetTailColor(System.Drawing.Color.LimeGreen);
            for (int g = 0; g < 10; g++)
            {
                t1.MoveForward(30);
                for (int w = 0; w < 20; w++)
                {
                    t1.MoveForward(40);
                    t1.TurnLeft(10);
                }
            }

 








        }
    }
}
