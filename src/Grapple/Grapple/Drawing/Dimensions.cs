using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grapple.Drawing
{
    public struct Dimensions
    {
        public float Height { get; private set; }
        public float Width { get; private set; }

        public Dimensions(float width, float height)
        {
            Height = height;
            Width = width;
        }
    }
}
