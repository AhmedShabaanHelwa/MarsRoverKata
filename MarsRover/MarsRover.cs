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

    public string Execute(string commandsString)
    {
        var commands = 
            commandsString.ToCharArray().Select(CommandsFactory.CreatFromCharacter).ToList();
        
        commands.ForEach(command => _rover = _rover.Apply(command));
        
        return _rover.GetState();
    }
}