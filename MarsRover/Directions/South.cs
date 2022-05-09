namespace MarsRover.Directions
{
    internal class South : IDirection
    {
        public Position MoveForward(Position position)
        {
            return new(position._x, position._y - 1);
        }
    }
}