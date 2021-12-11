using Progterv.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progterv.Entities
{
    public class Present : Toy
    {
        public SolidBrush RibbonBrush { get; set; }
        public SolidBrush BoxBrush { get; set; }
        public Present(Color box, Color ribbon)
        {            
            BoxBrush = new SolidBrush(box);
            RibbonBrush = new SolidBrush(ribbon);
        }
        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(BoxBrush, 0, 0, Width, Height);
            g.FillRectangle(RibbonBrush, 0, Height/2-5, Width, Height/5);
            g.FillRectangle(RibbonBrush, Width/2-5, 0, Width/5, Height);
        }
    }
}
