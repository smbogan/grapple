using Grapple.Drawing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrappleUI
{
    public class GraphicsPlotter : IPlotter
    {
        public Graphics graphics;
        private System.Drawing.Color color;
        private Pen pen;
        private Brush brush;

        public GraphicsPlotter(Graphics graphics)
        {
            this.graphics = graphics;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            color = System.Drawing.Color.Black;
            pen = new Pen(color);
            brush = new SolidBrush(color);
        }

        private Pen GetPen()
        {
            return pen;
        }

        private Brush GetBrush()
        {
            return brush;
        }

        public void SetColor(Grapple.Drawing.Color color, float width)
        {
            var drawingColor = System.Drawing.Color.FromArgb(color.Alpha, color.Red, color.Green, color.Blue);

            pen = new Pen(drawingColor, width);
            brush = new SolidBrush(drawingColor);
        }

        public void DrawRectangle(Position position, Dimensions size)
        {
            graphics.DrawRectangle(GetPen(), position.X, position.Y, size.Width, size.Height);
        }

        public void FillRectangle(Position position, Dimensions size)
        {
            graphics.FillRectangle(GetBrush(), position.X, position.Y, size.Width, size.Height);
        }

        public void DrawLine(Position start, Position end)
        {
            graphics.DrawLine(pen, start.X, start.Y, end.X, end.Y);
        }
    }
}
