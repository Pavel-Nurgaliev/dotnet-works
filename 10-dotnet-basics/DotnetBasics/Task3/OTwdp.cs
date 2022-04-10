using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class OTwdp : TwoDPointWithHash
    {
        public OTwdp(int x, int y) : base(x, y)
        { }
        public override int GetHashCode()
        {
            return HashCode.Combine(x, y);
        }
        public override string ToString()
        {
            return $"{GetHashCode()}";
        }
    }
}
