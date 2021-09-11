using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geom.MainLibrary
{
    public abstract class Shape
    {
        public virtual IList<Point> PointsGroup { get; init; } = new List<Point>();
        public void Draw()
        {
            foreach (var point in PointsGroup)
            {
                point.Draw();
            }
        }
        
    }
}
