using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class GeometricProgression : ISeries
    {
        protected int start;
        protected int step;
        protected int currentIndex;
        protected int prevStart;
        protected GeometricProgression(int start, int step)
        {
            this.start = start;
            this.step = step;
        }

        public int GetCurrent()
        {
            if (currentIndex != 0)
            {
                start = prevStart * step;

            }
            prevStart = this.start;
            return start;
        }
        public bool MoveNext()
        {
            currentIndex++;
            return true;
        }

        public void Reset()
        {
            currentIndex = 0;
        }
        private static GeometricProgression _instance;
        public static GeometricProgression Instance(int start, int step)
        {

            if (_instance == null)
            {
                _instance = new GeometricProgression(start, step);
            }
            return _instance;

        }
    }
}
