namespace MarsRover.Directions
{
    internal class East : IDirection
    {
        /// <summary>
        /// Move one step to the east.
        /// </summary>
        /// <remarks>
        /// it acts on the same object position
        /// </remarks>
        internal static Position MoveForward(Position position)
        {
            position._x++;
            return position;
        }
    }
}