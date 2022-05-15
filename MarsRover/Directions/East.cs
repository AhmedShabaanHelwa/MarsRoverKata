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
}