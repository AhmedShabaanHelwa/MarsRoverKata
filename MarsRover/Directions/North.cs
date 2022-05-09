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
        internal static Position MoveForward(Position position)
        {
            position._y++;
            return position;
        }
    }
}