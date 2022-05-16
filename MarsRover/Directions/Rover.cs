namespace MarsRover.Directions;

/// <summary>
/// Rover class.
/// </summary>
internal class Rover
{
    internal readonly IDirection? _direction;
    internal readonly Position? _position;

    public Rover(Position position, IDirection direction) => (_position, _direction) = (position,direction);
    /// <summary>
    /// Turns the rover left.
    /// </summary>
    /// <returns>New instance of the turned rover left.</returns>
    public Rover TurnLeft() => new Rover(_position, _direction.ToLeft());
    
    /// <summary>
    /// Turns the rover left.
    /// </summary>
    /// <returns>New instance of the turned rover right.</returns>
    
    public Rover TurnRight() => new Rover(_position, _direction.ToRight());
    /// <summary>
    /// Moves the rover one move forward.
    /// </summary>
    /// <returns>New instance of the moving rover.</returns>
    public Rover MoveForward() => new Rover(_direction.MoveForward(_position), _direction);
}