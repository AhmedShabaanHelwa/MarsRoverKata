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
    /// <summary>
    /// Returns the direction as string.
    /// </summary>
    /// <returns>Direction in string format</returns>
    string AsStringCommand();
}