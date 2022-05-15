namespace MarsRover;

public class Position
{
    public readonly int X;
    public readonly int Y;

    public Position(int x, int y) => (this.X, this.Y) = (x, y);
}