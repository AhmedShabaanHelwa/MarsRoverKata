using MarsRover.Commands;
using MarsRover.Rover;

namespace MarsRover;
/// <summary>
/// A Rover that is capable of exploring Mars!
/// </summary>
public class MarsRover
{
    private readonly string _initialState;
    private Rover.Rover _rover;

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
                var moveForwardCommand = new MoveForwardCommand();
                _rover = _rover.Apply(moveForwardCommand);
            }
            else if (c == 'R')
            {
                var turnRightCommand = new TurnRightCommand();
                _rover = _rover.Apply((dynamic)turnRightCommand);
            }
            else if (c == 'L')
            {
                var turnLeftCommand = new TurnLeftCommand();
                _rover = _rover.Apply(turnLeftCommand);
            }
        });
        return $"{_rover.Position.X}:{_rover.Position.Y}:{_rover.Direction.AsStringCommand()}";
    }
}