namespace MarsRover;

/// <summary>
/// Value object to hold position of the rover
/// </summary>
internal class Position
{
    internal int _x;
    internal int _y;
    // Default constructor
    public Position() 
    { 
        
    }
    public Position(int x, int y) => (this._x, this._y) = (x, y);
}
