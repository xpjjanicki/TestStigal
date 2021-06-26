using System.Collections.Generic;

namespace Stigal.AppCode
{
    public class Move
    {
        /// <summary>
        /// Generate rectangle
        /// </summary>
        /// <param name="w">width</param>
        /// <param name="h">height</param>
        /// <param name="p">start point</param>
        public List<AppPoint> GenerateShape(float w, float h, AppPoint p)
        {
            return new List<AppPoint>()
            {
                new AppPoint() { X = p.X, Y = p.Y },
                new AppPoint() { X = p.X + w, Y = p.Y },
                new AppPoint() { X = p.X + w, Y = p.Y + h },
                new AppPoint() { X = p.X, Y = p.Y + h }
            };
        }
    }
}
