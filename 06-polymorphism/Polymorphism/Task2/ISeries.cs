using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public interface ISeries
    {
        int GetCurrent();
        bool MoveNext();
        void Reset();
    }
}
