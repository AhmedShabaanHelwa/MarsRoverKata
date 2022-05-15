namespace MarsRover.Directions;

/// <summary>
/// Direction interface.
/// </summary>
internal interface IDirection
{
    /// <summary>
    /// Move the rover one step forward
    /// </summary>
    /// <param name="position">Initial position of the rover</param>
    /// <returns>New position of the rover after moving one step forward</returns>
    Position MoveForward(Position position);
}