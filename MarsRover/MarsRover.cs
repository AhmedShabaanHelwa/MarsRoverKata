using MarsRover.Directions;

namespace MarsRover;

public class MarsRover
{
    private readonly string _initialPosition;
    private Position _position;
    private IDirection _direction;

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
        string[] commandsParts = _initialPosition.Split(':');
        int x = int.Parse(commandsParts[0]);
        int y = int.Parse(commandsParts[1]);
        string directionStringCommand = commandsParts[2];

        _position = new Position(x: x, y: y);

        if (commands.ToLower() == "m")
        {
            _direction = DirectionFactory.CreateFrom(directionStringCommand);
            _position = _direction.MoveForward(_position);
        }

        return $"{_position.X}:{_position.Y}:{directionStringCommand}";
    }
}