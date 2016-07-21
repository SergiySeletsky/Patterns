namespace Patterns.Behavioral.Servant
{
    // Just a very simple container class for position.
    public class Position
    {
        public int xPosition;
        public int yPosition;

        public Position(int dx, int dy)
        {
            xPosition = dx;
            yPosition = dy;
        }
    }
}