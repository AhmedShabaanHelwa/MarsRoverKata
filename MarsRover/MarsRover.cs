using MarsRover.Directions;

namespace MarsRover;

public class MarsRover
{
    private readonly string _initialState;
    private IDirection? _direction;
    private Position? _position;
    public MarsRover(string initialState)
    {
        _initialState = initialState;
    }

    public string Execute(string commands)
    {
        // Parsing the command
        string[] states = _initialState.Split(':');
        int x = int.Parse(states[0]);
        int y = int.Parse(states[1]);
        string directionStringCommand = states[2];
        _position = new Position(x,y);
        // Forward
        if (commands == "M")
        {
            _direction = DirectionFactory.CreateFrom(directionStringCommand);
            _position = _direction.MoveForward(_position);
        }

        return $"{_position.X}:{_position.Y}:{directionStringCommand}";
    }
}
