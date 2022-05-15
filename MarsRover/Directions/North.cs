namespace MarsRover.Directions;

public class North : IDirection
{
    public Position MoveForward(Position position) => new Position(position.X, position.Y + 1);
}