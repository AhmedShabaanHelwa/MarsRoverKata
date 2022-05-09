using MarsRover.Directions;
namespace MarsRover;

public class MarsRover
{
    private readonly string _InittialState;
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
        string direction = states[2];

        // Forward
        if (commands == "M")
        {
            switch (direction)
            {
                // In North direction
                case "N":
                    _Position = North.MoveForward(_Position);
                    break;
                // In West Direction
                case "W":
                    _Position = West.MoveForward(_Position);
                    break;
                // In East Direction
                case "E":
                    _Position = East.MoveForward(_Position);
                    break;
            }
        }

        return $"{_Position._x}:{_Position._y}:{direction}";
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
