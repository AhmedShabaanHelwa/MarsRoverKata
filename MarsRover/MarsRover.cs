namespace MarsRover;

public class MarsRover
{
    private string _InittialState;
    public MarsRover(string initialState) => _InittialState = initialState;

    public string Execute(string commands)
    {
        return _InittialState;
    }
}
