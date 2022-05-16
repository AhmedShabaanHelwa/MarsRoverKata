using MarsRover.Commands;
using MarsRover.Directions;

namespace MarsRover.Rover;

/// <summary>
/// Rover class.
/// </summary>
internal class Rover
{
    private readonly IDirection? _direction;
    private readonly Position? _position;

    public Rover(Position position, IDirection direction) => (_position, _direction) = (position,direction);
    
    /// <summary>
    /// Applies the command to this rover.
    /// </summary>
    /// <param name="command">Command to be applied by this rover.</param>
    /// <returns>New instance of rover after applying the command.</returns>
    public Rover Apply(ICommand command) => ApplyCommand((dynamic)command);
    
    /// <summary>
    /// Returns the state of this rover, in terms of position and direction.
    /// </summary>
    /// <returns>"X:Y:Direction" of this rover.</returns>
    public string GetState() => $"{_position.X}:{_position.Y}:{_direction.AsStringCommand()}";

    /// <summary>
    /// Applies Move Forward command to this rover.
    /// </summary>
    /// <param name="moveForwardCommand">Concrete implementation of Move Fowrard Command.</param>
    /// <returns>New instance of rover after applying the command.</returns>
    private Rover ApplyCommand(MoveForwardCommand moveForwardCommand) => new Rover(_direction.MoveForward(_position), _direction);
    
    /// <summary>
    /// Applies Turn Right command to this rover.
    /// </summary>
    /// <param name="turnRightCommand">Concrete implementation of Turn Right Command.</param>
    /// <returns>New instance of rover after applying the command.</returns>
    private Rover ApplyCommand(TurnRightCommand turnRightCommand) => new Rover(_position, _direction.ToRight());
    
    /// <summary>
    /// Applies Turn Left command to this rover.
    /// </summary>
    /// <param name="turnLeftCommand">Concrete implementation of Turn Left Command.</param>
    /// <returns>Concrete implementation of Move Fowrard Command.</returns>
    private Rover ApplyCommand(TurnLeftCommand turnLeftCommand) => new Rover(_position, _direction.ToLeft());
}