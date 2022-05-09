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
        public Position MoveForward(Position position)
        {
            return new (position._x+1,position._y);
        }
    }
}