using MarsRover.Directions;

namespace MarsRover;
/// <summary>
/// A Rover that is capable of exploring Mars!
/// </summary>
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