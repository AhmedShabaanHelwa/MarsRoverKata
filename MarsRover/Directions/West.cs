namespace MarsRover.Directions
{
    internal class West : IDirection
    {

        /// <summary>
        /// Move one step to the West.
        /// </summary>
        /// <remarks>
        /// it acts on the same object position
        /// </remarks>
        public Position MoveForward(Position position) => new(position._x - 1, position._y);
    }
}