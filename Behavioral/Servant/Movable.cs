namespace Patterns.Behavioral.Servant
{
    // Interface specifying what serviced classes needs to implement, to be
    // serviced by servant.
    public interface Movable
    {
        void setPosition(Position p);

        Position getPosition();
    }
}