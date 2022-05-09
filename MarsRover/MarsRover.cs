namespace MarsRover;

public class MarsRover
{
    private readonly string _InittialState;
    private readonly Position _Position;
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
                    MoveNorth();
                    break;
                // In West Direction
                case "W":
                    MoveWest();
                    break;
                // In East Direction
                case "E":
                    MoveEast();
                    break;
            }
        }

        return $"{_Position._x}:{_Position._y}:{direction}";
    }
    /// <summary>
    /// Move one step to the east.
    /// </summary>
    /// <remarks>
    /// it acts on the same object position
    /// </remarks>
    private void MoveEast()
    {
        _Position._x++;
    }
    /// <summary>
    /// Move one step to the West.
    /// </summary>
    /// <remarks>
    /// it acts on the same object position
    /// </remarks>
    private void MoveWest()
    {
        _Position._x--;
    }
    /// <summary>
    /// Move one step to the North.
    /// </summary>
    /// <remarks>
    /// it acts on the same object position
    /// </remarks>
    private void MoveNorth()
    {
        _Position._y++;
    }

    class Position
    {
        internal int _x;
        internal int _y;
    }
}
