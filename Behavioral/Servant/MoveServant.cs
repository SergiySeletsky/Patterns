namespace Patterns.Behavioral.Servant
{
    // Servant class, offering its functionality to classes implementing
    // Movable Interface
    public class MoveServant
    {
        // Method, which will move Movable implementing class to position where
        public void moveTo(Movable serviced, Position where)
        {
            // Do some other stuff to ensure it moves smoothly and nicely, this is
            // the place to offer the functionality
            serviced.setPosition(where);
        }

        // Method, which will move Movable implementing class by dx and dy
        public void moveBy(Movable serviced, int dx, int dy)
        {
            // this is the place to offer the functionality
            dx += serviced.getPosition().xPosition;
            dy += serviced.getPosition().yPosition;
            serviced.setPosition(new Position(dx, dy));
        }
    }
}