using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grapple.Drawing;

namespace GrappleUI
{
    public partial class GrappleControl : UserControl
    {
        PaintableGraph graph;

        public GrappleControl()
        {
            InitializeComponent();
            graph = new PaintableGraph(this.Width, this.Height);
        }

        private void GrappleControl_Paint(object sender, PaintEventArgs e)
        {
            graph.Paint(new GraphicsPlotter(e.Graphics), new Position(0, 0));
        }

        public void Add(Paintable paintable, Position position)
        {
            graph.Add(paintable, position);
        }

        private void GrappleControl_Resize(object sender, EventArgs e)
        {
            graph.Size = new Dimensions(this.Width, this.Height);
        }
    }
}
