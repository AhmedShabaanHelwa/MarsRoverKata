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
        internal static Position MoveForward(Position position)
        {
            position._x--;
            return position;
        }
    }
}