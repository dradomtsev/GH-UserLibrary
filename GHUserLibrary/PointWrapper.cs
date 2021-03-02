//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//using Rhino;
using Rhino.Geometry;

namespace GHUserLibrary
{
    public class PointWrapper
    {
        public Point3d pPointInt;
        public PointWrapper(Point3d pPointExt)
        {
            pPointInt = pPointExt;
        }
    }
}
