using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stigal
{
    class Rectangle
    {
        /// <summary>
        /// Left Top
        /// </summary>
        public Point P1 { get; set; }

        /// <summary>
        /// Right Top
        /// </summary>
        public Point P2 { get; set; }

        /// <summary>
        /// Right Bottom
        /// </summary>
        public Point P3 { get; set; }

        /// <summary>
        /// Left Bottom
        /// </summary>
        public Point P4 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="w">width</param>
        /// <param name="h">height</param>
        /// <param name="p">start point</param>
        public Rectangle GenerateRectangle (float w, float h, Point p)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.P1.X = p.X;
            rectangle.P1.Y = p.Y;

            rectangle.P2.X = p.X + w;
            rectangle.P2.Y = p.Y;

            rectangle.P3.X = p.X + w;
            rectangle.P3.Y = p.Y + h;

            rectangle.P4.X = p.X;
            rectangle.P4.Y = p.Y + h;

            return rectangle;
        }
    }
}
