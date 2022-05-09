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
            return direction switch
            {
                // In North direction
                "N" => new North(),
                // In West Direction
                "W" => new West(),
                // In East Direction
                "E" => new East(),
                // In South Direction
                "S" => new South(),
                _ => throw new NotSupportedException(message: $"Direction {direction} is not supported!"),
            };
        }
    }
}