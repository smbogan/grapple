using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grapple.Drawing
{
    public struct Color
    {
        public byte Alpha { get; set; }
        public byte Blue { get; set; }
        public byte Green { get; set; }
        public byte Red { get; set; }

        public Color(byte red, byte green, byte blue, byte alpha)
        {
            Alpha = alpha;
            Red = red;
            Green = green;
            Blue = blue;
        }
    }
}
