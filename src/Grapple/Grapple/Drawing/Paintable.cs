using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grapple.Drawing
{
    public class Paintable
    {
        public Dimensions Size { get; set; }

        public Paintable(float width, float height)
        {
            Size = new Dimensions(width, height);
        }

        public virtual void Paint(IPlotter plotter, Position position)
        {
            plotter.SetColor(new Color(255, 255, 255, 255), 2);
            plotter.FillRectangle(position, Size);
            plotter.SetColor(new Color(255, 0, 0, 255), 2);
            plotter.DrawRectangle(position, Size);
            plotter.DrawLine(position, new Position(position.X + Size.Width, position.Y + Size.Height));
            plotter.DrawLine(new Position(position.X + Size.Width, position.Y), new Position(position.X, position.Y + Size.Height));
        }
    }
}
