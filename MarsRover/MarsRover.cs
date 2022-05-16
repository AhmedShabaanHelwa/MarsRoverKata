using MarsRover.Directions;

namespace MarsRover;

internal class Rover
{
    internal readonly IDirection? _direction;
    internal readonly Position? _position;

    public Rover(Position position, IDirection direction) => (_position, _direction) = (position,direction);

    public Rover TurnLeft() => new Rover(_position, _direction.ToLeft());

    public Rover MoveForward() => new Rover(_direction.MoveForward(_position), _direction);

    public Rover TurnRight() => new Rover(_position, _direction.ToRight());
}

internal abstract class RoverFactory
{
    internal static Rover CreatFromInitialState(string initialState)
    {
        string[] states = initialState.Split(':');
        int x = int.Parse(states[0]);
        int y = int.Parse(states[1]);
        string directionStringCommand = states[2];
        Position position = new Position(x, y);
        IDirection direction = DirectionFactory.CreateFrom(directionStringCommand);

        return new Rover(position: position, direction: direction);
    }
}

public class MarsRover
{
    private readonly string _initialState;
    private Rover _rover;

    public MarsRover(string initialState)
    {
        _initialState = initialState;
        _rover = RoverFactory.CreatFromInitialState(_initialState);
    }

    public string Execute(string commands)
    {
        commands.ToCharArray().ToList().ForEach(c =>
        {
            if (c == 'M')
            {
                _rover = _rover.MoveForward();
            }
            else if (c == 'R')
            {
                _rover = _rover.TurnRight();
            }
            else if (c == 'L')
            {
                _rover = _rover.TurnLeft();
            }
        });
        return $"{_rover._position.X}:{_rover._position.Y}:{_rover._direction.AsStringCommand()}";
    }
}