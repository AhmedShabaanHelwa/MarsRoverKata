namespace MarsRover.Directions
{
    internal class North : IDirection
    {
        /// <summary>
        /// Move one step to the North.
        /// </summary>
        /// <remarks>
        /// it acts on the same object position
        /// </remarks>
        public Position MoveForward(Position position) => new(position._x, position._y + 1);
    }
}