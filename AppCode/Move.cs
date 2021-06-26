namespace Stigal.AppCode
{
    public class Move
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="w">width</param>
        /// <param name="h">height</param>
        /// <param name="p">start point</param>
        public AppRectangle GenerateRectangle(float w, float h, AppPoint p)
        {
            return new AppRectangle
            {
                P1 = new AppPoint() { X = p.X, Y = p.Y },
                P2 = new AppPoint() { X = p.X + w, Y = p.Y },
                P3 = new AppPoint() { X = p.X + w, Y = p.Y + h },
                P4 = new AppPoint() { X = p.X, Y = p.Y + h }
            };
        }
    }
}
