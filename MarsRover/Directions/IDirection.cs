using MarsRover.Rover;

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
    /// Turn the rover's direction left.
    /// </summary>
    /// <returns>New direction after turning left</returns>
    IDirection ToLeft();
    
    /// <summary>
    /// Turn the rover's direction right.
    /// </summary>
    /// <returns>New direction after turning right</returns>
    IDirection ToRight();

    /// <summary>
    /// Returns the direction as string.
    /// </summary>
    /// <returns>Direction in string format</returns>
    string AsStringCommand();
}