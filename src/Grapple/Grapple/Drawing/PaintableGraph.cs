using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grapple.Drawing
{
    public class PaintableGraph : Paintable
    {
        List<Paintable> Paintables { get; set; }
        Dictionary<Paintable, Position> Positions { get; set; }

        public PaintableGraph(float width, float height)
            : base(width, height)
        {
            Paintables = new List<Paintable>();
            Positions = new Dictionary<Paintable, Position>();
        }

        public int Count
        {
            get
            {
                return Paintables.Count;
            }
        }

        public void Add(Paintable paintable, Position position)
        {
            Paintables.Add(paintable);
            Positions[paintable] = position;
        }

        public Paintable this[int index]
        {
            get
            {
                return Paintables[index];
            }
        }

        public override void Paint(IPlotter plotter, Position position)
        {
            foreach (var p in Paintables)
            {
                p.Paint(plotter, Positions[p].Translate(position));
            }
        }
    }
}
