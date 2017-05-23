using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;
using System.Threading;

namespace TurtleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Turtle.PenUp();
            GraphicsWindow.KeyDown +=GraphicsWindow_KeyDown;

            GraphicsWindow.BrushColor = "Red";
            var eat = Shapes.AddRectangle(10, 10);

            while (true)
            {
                Random x = new Random();
                int x_eat = x.Next(0, 500);
                int x_eat1 = x_eat + 10;

                    Thread.Sleep(20);

                Random y = new Random();
                int y_eat = y.Next(1, 500);
                int y_eat1 = y_eat + 10;
                
                    Shapes.Move(eat, x_eat, y_eat);

                int x_trt = Turtle.X;
                int y_trt = Turtle.Y;
                
                if (x_eat<x_trt && x_trt<x_eat1 && y_eat<y_trt && y_trt<y_eat1)
                {
                    Shapes.Move(eat, x.Next(0, 500), y.Next(0, 500));
                    Turtle.Move(10);
                }
                else Turtle.Move(10);

            }
        }

        private static void GraphicsWindow_KeyDown()
        {
            if (GraphicsWindow.LastKey == "Up")
            { Turtle.Angle = 0; }
            else if (GraphicsWindow.LastKey == "Down")
            { Turtle.Angle = 180; }
            else if (GraphicsWindow.LastKey == "Left")
            { Turtle.Angle = 270; }
            else if (GraphicsWindow.LastKey == "Right")
            { Turtle.Angle = 90; }
        }
    }
}
