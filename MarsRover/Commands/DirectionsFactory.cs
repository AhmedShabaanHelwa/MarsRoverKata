using MarsRover.Directions;

namespace MarsRover.Commands
{
    internal static class DirectionsFactory
    {
        /// <summary>
        /// Direction factory to create the proper concrete implementation of IDirection
        /// </summary>
        /// <param name="direction">Stringed direction</param>
        /// <returns>Concrete implementation of the direction</returns>
        internal static IDirection CreateFrom(string direction) =>
            direction switch
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