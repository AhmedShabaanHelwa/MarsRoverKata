namespace MarsRover.Directions;

/// <summary>
/// West direction class
/// </summary>
internal class West : IDirection
{
    /// <summary>
    /// Move one step to the West.
    /// </summary>
    /// <remarks>
    /// It acts on the same object position
    /// </remarks>
    public Position MoveForward(Position position) => new(position.X - 1, position.Y);
    
    /// <summary>
    /// Turn the rover's direction left.
    /// </summary>
    /// <returns>New direction pointing the South</returns>
    public IDirection ToLeft() => new South();
    
    /// <summary>
    /// Turn the rover's direction right.
    /// </summary>
    /// <returns>New direction pointing the North</returns>
    public IDirection ToRight() => new North();

    /// <summary>
    /// Returns the direction as string.
    /// </summary>
    /// <returns>Direction in string format</returns>
    public string AsStringCommand() => "W";
}