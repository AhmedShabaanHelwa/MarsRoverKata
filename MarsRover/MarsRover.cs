using MarsRover.Directions;
namespace MarsRover;

public class MarsRover
{
    private readonly string _InittialState;
    private IDirection _Direction;
    private Position _Position;
    public MarsRover(string initialState)
    {
        _InittialState = initialState;
        _Position = new Position();
    }

    public string Execute(string commands)
    {
        // Parsing the command
        string[] states = _InittialState.Split(':');
        _Position._x = int.Parse(states[0]);
        _Position._y = int.Parse(states[1]);
        string directionStringCommand = states[2];

        // Forward
        if (commands == "M")
        {
            _Direction = DirectionFactory.CreateFrom(directionStringCommand);
            _Position = _Direction.MoveForward(_Position);
        }

        return $"{_Position._x}:{_Position._y}:{directionStringCommand}";
    }
}

/// <summary>
/// Value object to hold position of the rover
/// </summary>
internal class Position
{
    internal int _x;
    internal int _y;
}
