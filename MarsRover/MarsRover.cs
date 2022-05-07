namespace MarsRover;

public class MarsRover
{
    private string _InittialState;
    public MarsRover(string initialState) => _InittialState = initialState;

    public string Execute(string command)
    {
        // Parsing the command
        string[] commands = command.Split(':');
        int x = int.Parse(commands[0]);
        int y = int.Parse(commands[1]);
        int direction = int.Parse(commands[2]);

        // Moving in Y-Axis. Forward and backward
        if(command == "M")
        {
            return $"{x}:{y+1}:{direction}";
        }

        return _InittialState;
    }
}
