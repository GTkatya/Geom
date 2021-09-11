using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geom.MainLibrary.Shapes.Lines
{
   public class VerticalLine : Line
    {
        public VerticalLine(int beginY, int endY, int x)
        {
            for (int i = beginY; i<=endY; i++)
            {
                PointsGroup.Add(new Point(x, i));
            }
        }
    }
}
