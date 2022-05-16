using MarsRover.Commands;
using MarsRover.Directions;

namespace MarsRover.Rover;

/// <summary>
/// Rover class.
/// </summary>
internal class Rover
{
    internal readonly IDirection? Direction;
    internal readonly Position? Position;

    public Rover(Position position, IDirection direction) => (Position, Direction) = (position,direction);
    
    /// <summary>
    /// Applies the command to this rover.
    /// </summary>
    /// <param name="command">Command to be applied by this rover.</param>
    /// <returns>New instance of rover after applying the command.</returns>
    public Rover Apply(ICommand command) => ApplyCommand((dynamic)command);
    
    /// <summary>
    /// Applies Move Forward command to this rover.
    /// </summary>
    /// <param name="moveForwardCommand">Concrete implementation of Move Fowrard Command.</param>
    /// <returns>New instance of rover after applying the command.</returns>
    private Rover ApplyCommand(MoveForwardCommand moveForwardCommand) => new Rover(Direction.MoveForward(Position), Direction);
    
    /// <summary>
    /// Applies Turn Right command to this rover.
    /// </summary>
    /// <param name="turnRightCommand">Concrete implementation of Turn Right Command.</param>
    /// <returns>New instance of rover after applying the command.</returns>
    private Rover ApplyCommand(TurnRightCommand turnRightCommand) => new Rover(Position, Direction.ToRight());
    
    /// <summary>
    /// Applies Turn Left command to this rover.
    /// </summary>
    /// <param name="turnLeftCommand">Concrete implementation of Turn Left Command.</param>
    /// <returns>Concrete implementation of Move Fowrard Command.</returns>
    private Rover ApplyCommand(TurnLeftCommand turnLeftCommand) => new Rover(Position, Direction.ToLeft());
}