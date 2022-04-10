using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{

    class Line : Figure
    {
        protected double line;
        public Line(double line)
        {
            this.line = line;
        }
        public override void Draw()
        {
            Console.WriteLine($"It\'s GetType().Name with length {line}");
        }

    }
}
