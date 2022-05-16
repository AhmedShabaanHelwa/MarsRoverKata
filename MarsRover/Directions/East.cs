using MarsRover.Rover;

namespace MarsRover.Directions;

/// <summary>
/// East direction class
/// </summary>
internal class East : IDirection
{
    /// <summary>
    /// Move one step to the east.
    /// </summary>
    /// <remarks>
    /// It acts on the same object position
    /// </remarks>
    public Position MoveForward(Position position) => new(position.X + 1, position.Y);
    
    /// <summary>
    /// Turn the rover's direction left.
    /// </summary>
    /// <returns>New direction pointing the North</returns>
    public IDirection ToLeft() => new North();
    
    /// <summary>
    /// Turn the rover's direction right.
    /// </summary>
    /// <returns>New direction pointing the South</returns>
    public IDirection ToRight() => new South();

    /// <summary>
    /// Returns the direction as string.
    /// </summary>
    /// <returns>Direction in string format</returns>
    public string AsStringCommand() => "E";
}