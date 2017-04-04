//MIT, 2017, WinterDev
//MIT, 2014, PouletFrit
//MIT, 2009, Alan Shaw
 

namespace CsDelaunay
{
    public class Circle
    {

        public Vector2f center;
        public float radius;

        public Circle(float centerX, float centerY, float radius)
        {
            this.center = new Vector2f(centerX, centerY);
            this.radius = radius;
        }

        public override string ToString()
        {
            return "Circle (center: " + center + "; radius: " + radius + ")";
        }
    }
}