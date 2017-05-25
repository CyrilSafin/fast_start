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
            int x = 200;
            int y = 200;

            Random rand = new Random();

            Shapes.Move(eat, x, y);

            while (true)
            {
                Turtle.Move(10);

                if (Turtle.X >= x && Turtle.X <= (x + 10) && Turtle.Y >= y && Turtle.Y <= (y + 10))
                {
                    x = rand.Next(0, GraphicsWindow.Width);
                    y = rand.Next(0, GraphicsWindow.Height);
                    Shapes.Move(eat, x, y);
                }
          

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
