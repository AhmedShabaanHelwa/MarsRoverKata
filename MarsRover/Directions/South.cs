namespace MarsRover.Directions;

/// <summary>
/// South direction class
/// </summary>
internal class South : IDirection
{
    /// <summary>
    /// Move one step to the South.
    /// </summary>
    /// <remarks>
    /// It acts on the same object position
    /// </remarks>
    public Position MoveForward(Position position) => new(position.X, position.Y - 1);

    /// <summary>
    /// Turn the rover's direction left.
    /// </summary>
    /// <returns>New direction pointing the East</returns>
    public IDirection ToLeft() => new East();

    /// <summary>
    /// Turn the rover's direction right.
    /// </summary>
    /// <returns>New direction pointing the West</returns>
    public IDirection ToRight() => new West();

    /// <summary>
    /// Returns the direction as string.
    /// </summary>
    /// <returns>Direction in string format</returns>
    public string AsStringCommand() => "S";
}