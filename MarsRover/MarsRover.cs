namespace MarsRover;

public class MarsRover
{
    private readonly string _initialPosition;

    public MarsRover(string initialPosition)
    {
        _initialPosition = initialPosition;
    }
    /// <summary>
    /// Execute function of command pattern
    /// </summary>
    /// <param name="commands">Accepted commands to execute</param>
    /// <returns></returns>
    public string Execute(string commands)
    {
        return _initialPosition;
    }
}