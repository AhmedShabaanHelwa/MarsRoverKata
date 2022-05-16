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
            _command = CommandsFactory.CreatFromCharacter(c);

            _rover = _rover.Apply(_command);
        });
        
        return $"{_rover.Position.X}:{_rover.Position.Y}:{_rover.Direction.AsStringCommand()}";
    }
}