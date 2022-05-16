namespace MarsRover.Rover;

/// <summary>
/// Value object to hold position of the rover
/// </summary>
internal class Position
{
    internal readonly int X;
    internal readonly int Y;

    public Position(int x, int y) => (this.X, this.Y) = (x, y);
}
