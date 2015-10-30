using GrappleUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApplication
{
    public partial class Form1 : Form
    {
        GrappleControl grapple;

        public Form1()
        {
            InitializeComponent();
            grapple = new GrappleControl();
            grapple.Dock = DockStyle.Fill;
            this.Controls.Add(grapple);

            grapple.Add(new Grapple.Drawing.Paintable(50, 50), new Grapple.Drawing.Position(5, 5));
            grapple.Add(new Grapple.Drawing.Paintable(50, 50), new Grapple.Drawing.Position(45, 45));
            grapple.Add(new Grapple.Drawing.Paintable(20, 120), new Grapple.Drawing.Position(200, 45));
        }
    }
}
