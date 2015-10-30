using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grapple.Drawing
{
    public interface IPlotter
    {
        void SetColor(Grapple.Drawing.Color color, float width);

        void DrawLine(Position start, Position end);
        void DrawRectangle(Position position, Dimensions size);
        void FillRectangle(Position position, Dimensions size);
    }
}
