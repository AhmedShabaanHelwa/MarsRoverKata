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
    }

    public string Execute(string commands)
    {
        // Parsing the command
        string[] states = _InittialState.Split(':');
        int x = int.Parse(states[0]);
        int y = int.Parse(states[1]);
        string directionStringCommand = states[2];
        _Position = new Position(x,y);
        // Forward
        if (commands == "M")
        {
            _Direction = DirectionFactory.CreateFrom(directionStringCommand);
            _Position = _Direction.MoveForward(_Position);
        }

        return $"{_Position.X}:{_Position.Y}:{directionStringCommand}";
    }
}
