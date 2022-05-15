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
    /// Returns the direction as string.
    /// </summary>
    /// <returns>Direction in string format</returns>
    public string AsStringCommand() => "W";
}