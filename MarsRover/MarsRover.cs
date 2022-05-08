namespace MarsRover;

public class MarsRover
{
    private string _InittialState;
    public MarsRover(string initialState) => _InittialState = initialState;

    public string Execute(string commands)
    {
        // Parsing the command
        string[] states = _InittialState.Split(':');
        int x = int.Parse(states[0]);
        int y = int.Parse(states[1]);
        string direction = states[2];

        // Forward
        if (commands == "M")
        {
            // In North direction
            if (direction == "N") y++;
            // In West Direction
            if (direction == "W") x--;
            // In East Direction
            if (direction == "E") x++;
        }

        return $"{x}:{y}:{direction}";
    }
}
