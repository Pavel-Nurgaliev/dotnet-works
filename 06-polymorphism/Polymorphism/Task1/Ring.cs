using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Ring : Figure
    {
        protected double radius1;
        protected double radius2;
        public Ring(double radius1, double radius2)
        {
            this.radius1 = radius1;
            this.radius2 = radius2;

        }
        public override void Draw()
        {
            Console.WriteLine($"It\'s {GetType().Name}" +
                $" with inner radius {radius1} and outer radius {radius2}");
        }

    }
}
