using MarsRover.Directions;

namespace MarsRover
{
    internal static class DirectionFactory
    {

        /// <summary>
        /// Direction factory to create the proper concrete implementation of IDirection
        /// </summary>
        /// <param name="direction">Stringfied direction</param>
        /// <returns></returns>
        internal static IDirection CreateFrom(string direction)
        {
            switch (direction)
            {
                // In North direction
                case "N":
                    return new North();
                // In West Direction
                case "W":
                    return new West();
                // In East Direction
                case "E":
                    return new East();
                default:
                    throw new NotSupportedException(message: $"Direction {direction} is not supported!");
            }
        }
    }
}