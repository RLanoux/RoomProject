using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoomProject
{
    class Quadrangle3D : Quadrangle
    {
        public Quadrangle3D()
        {
            dHeight = 1.0;
        }

        public Quadrangle3D(Double initHeight)
        {
            dHeight = initHeight;
        }

        public Double ShowBaseArea()
        {
            return ShowArea();
        }

        public Double ShowSurfaceArea()
        {
            return (2 * (dLength * dWidth)) + (((2 * dWidth) + (2 * dLength)) * dHeight);
        }

        public Double ShowVolume()
        {
            return dHeight * dLength * dWidth;
        }

        protected Double dHeight;
    }
}
