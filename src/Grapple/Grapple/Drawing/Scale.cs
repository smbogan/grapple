using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grapple.Drawing
{
    public struct Scale
    {
        public float Value { get; private set; }

        public Scale(float value)
        {
            Value = value;
        }
    }
}
