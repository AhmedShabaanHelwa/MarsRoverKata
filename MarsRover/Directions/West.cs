namespace MarsRover.Directions;

public class West : IDirection
{
    public Position MoveForward(Position position) => new Position(position.X - 1, position.Y);
}