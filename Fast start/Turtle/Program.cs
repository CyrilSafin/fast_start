using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;


namespace TurtleTrainig
{
    class Program
    {
        static void letterT()
        {   
            
            Turtle.Move(60);
            Turtle.TurnLeft();
            Turtle.Move(30);
            Turtle.Turn(180);
            Turtle.Move(60);
        }
        static void letterO()
        {
            for (int i = 0; i < 4; i++)
            {
                Turtle.Move(60);
                Turtle.TurnRight();
            }
        }
        static void letterP()
        {
            Turtle.Move(60);
            for (int i = 0; i < 3; i++)
            {
                Turtle.TurnRight();
                Turtle.Move(45);
            }
        }

        static void Main(string[] args)
        {
            Turtle.Speed = 9;

            //ТОРТ

            //T
                Turtle.X = 200;
                Turtle.Y = 200;
                letterT();
            //T-end

            //O
                Turtle.Angle = 0;
                Turtle.X = 260;
                Turtle.Y = 200;
                letterO();
            //O-end

            //P
                Turtle.Angle = 0;
                Turtle.X = 360;
                Turtle.Y = 200;
                letterP();
            //P-end
            
            //T
                Turtle.Angle = 0;
                Turtle.X = 460;
                Turtle.Y = 200;
                letterT();
            //T-end

        }
    }
}
