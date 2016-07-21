namespace Patterns.Behavioral.Servant
{
    // One of geometric classes
    public class Ellipse : Movable
    {
        // Position of the geometric object on some canvas
        private Position p;

        // Method, which sets position of geometric object
        public void setPosition(Position p)
        {
            this.p = p;
        }

        // Method, which returns position of geometric object
        public Position getPosition()
        {
            return p;
        }
    }
}