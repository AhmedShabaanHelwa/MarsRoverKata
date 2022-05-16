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
    private ICommand _command;

    public MarsRover(string initialState)
    {
        _initialState = initialState;
        _rover = RoverFactory.CreatFromInitialState(_initialState);
    }

    public string Execute(string commandsString)
    {
        commandsString.ToCharArray().ToList().ForEach(c =>
        {
            if (c == 'M')
            {
                _command = new MoveForwardCommand();
            }
            else if (c == 'R')
            {
                _command = new TurnRightCommand();
            }
            else if (c == 'L')
            {
                _command = new TurnLeftCommand();
            }
            
            _rover = _rover.Apply(_command);
        });
        
        return $"{_rover.Position.X}:{_rover.Position.Y}:{_rover.Direction.AsStringCommand()}";
    }
}