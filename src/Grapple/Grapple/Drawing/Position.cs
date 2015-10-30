using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grapple.Drawing
{
    public struct Position
    {
        public float X { get; private set; }
        public float Y { get; private set; }

        public Position(float x, float y)
        {
            X = x;
            Y = y;
        }

        public Position Translate(float x, float y)
        {
            return new Position(this.X + x, this.Y + y);
        }

        public Position Translate(Position position)
        {
            return new Position(this.X + position.X, this.Y + position.Y);
        }
    }
}
