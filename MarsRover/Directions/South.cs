namespace MarsRover.Directions
{
    internal class South : IDirection
    {
        public Position MoveForward(Position position) => new(position.X, position.Y - 1);
    }
}