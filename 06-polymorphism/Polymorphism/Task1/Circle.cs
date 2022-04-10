using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Circle : Figure
    {
        protected double radius;
        public Circle(double radius)
        {
            this.radius = radius;

        }
        public override void Draw()
        {
            Console.WriteLine($"It\' {GetType().Name} with radius {radius}");
        }


    }
}
