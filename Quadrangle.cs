using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoomProject
{
    class Quadrangle
    {
        public Quadrangle()
        {
            dLength = 1.0;
            dWidth = 1.0;
        }

        public Quadrangle(Double initLength, Double initWidth)
        {
            dLength = initLength;
            dWidth = initWidth;
        }

        public Double ShowLength()
        {
            return dLength;
        }

        public Double ShowWidth()
        {
            return dWidth;
        }

        public Double ShowArea()
        {
            return dWidth * dLength;
        }

        public Double ShowPerimeter()
        {
            return (2 * dLength) + (2 * dWidth);
        }

        protected Double dLength;
        protected Double dWidth;
    }
}
