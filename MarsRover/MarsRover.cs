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
                case "N": _Position._y++;
                    break;
                // In West Direction
                case "W": _Position._x--;
                    break;
                // In East Direction
                case "E": _Position._x++; 
                    break;
            }
        }

        return $"{_Position._x}:{_Position._y}:{direction}";
    }

    class Position
    {
        internal int _x;
        internal int _y;
    }
}
