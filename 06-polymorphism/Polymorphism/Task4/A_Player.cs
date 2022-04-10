using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    abstract class A_Player : IPlayer, IRun
    {
        public abstract string Name(string name);
        public abstract void Run(double posX, double posY);
    }
}
