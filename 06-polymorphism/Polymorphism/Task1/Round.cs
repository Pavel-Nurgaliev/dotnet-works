using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Round : Figure
    {
        protected double radius;
        public Round(double radius)
        {
            this.radius = radius;
        }
        public override void Draw()
        {
            Console.WriteLine($"It\'s {GetType().Name} with length {Math.PI * radius * radius}");
        }

    }
}
