using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geom.MainLibrary.Shapes.Lines
{
    public class HorizontalLine : Line
    {
        public HorizontalLine(int beginX, int endX, int y)
        {
            if (y < 0 || beginX < 0 || endX < beginX)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = beginX; i <= endX; i++)
            {
                PointsGroup.Add(new Point(i, y));
            }
        }
    }
}
