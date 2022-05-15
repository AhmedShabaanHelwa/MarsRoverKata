namespace MarsRover.Directions;

/// <summary>
/// North direction class
/// </summary>
internal class North : IDirection
{
    /// <summary>
    /// Move one step to the North.
    /// </summary>
    /// <remarks>
    /// it acts on the same object position
    /// </remarks>
    public Position MoveForward(Position position) => new(position.X, position.Y + 1);
    
    /// <summary>
    /// Returns the direction as string.
    /// </summary>
    /// <returns>Direction in string format</returns>
    public string AsStringCommand() => "N";

    public IDirection ToRight() => new East();
}