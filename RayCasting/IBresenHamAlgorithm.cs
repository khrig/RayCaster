using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayCasting
{
    public interface IBresenHamAlgorithm {
        List<Point> Line(int x, int y, int x2, int y2);
    }
}
