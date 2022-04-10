using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    abstract class AbstractWorld : IObject, IColor
    {
        public abstract void SetPosition(double posX, double posY);
        public abstract void SetColor(string color);
    }
}
