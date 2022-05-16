using MarsRover.Commands;
using MarsRover.Directions;

namespace MarsRover.Rover;

/// <summary>
/// Rover class.
/// </summary>
internal class Rover
{
    internal readonly IDirection? _direction;
    internal readonly Position? _position;

    public Rover(Position position, IDirection direction) => (_position, _direction) = (position,direction);

    public Rover Apply(ICommand command)
    {
        return ApplyCommand((dynamic)command);
    }

    private Rover ApplyCommand(MoveForwardCommand moveForwardCommand)
    {
        return new Rover(_direction.MoveForward(_position), _direction);
    }

    private Rover ApplyCommand(TurnRightCommand turnRightCommand)
    {
        return  new Rover(_position, _direction.ToRight());
    }

    private Rover ApplyCommand(TurnLeftCommand turnLeftCommand)
    {
        return new Rover(_position, _direction.ToLeft());
    }
}