namespace MarsRover.Directions
{
    internal class South : IDirection
    {
        public Position MoveForward(Position position)
        {
            position._y--;
            return position;
        }
    }
}