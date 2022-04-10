using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Player : A_Player
    {
        private double _posX, _posY;
        private string _name;
        public Player(double posX, double posY)
        {
            _posX = posX;
            _posY = posY;
        }
        public override void Run(double posX, double posY)
        {

        }
        public override string Name(string name)
        {
            ControlName(name);
            _name = name;
            return (name);
        }
        public void ControlName(string name) //control to corectness of writing name
        {

        }
    }
}
