using MarsRover.Directions;

namespace MarsRover;

internal class Rover
{
    internal IDirection? _direction;
    internal Position? _position;

    public Rover()
    {
    }

    public void TurnLeft()
    {
        this._direction = this._direction.ToLeft();
    }

    public void MoveForward()
    {
        this._position = this._direction.MoveForward(this._position);
    }

    public void TurnRight()
    {
        this._direction = this._direction.ToRight();
    }
}

public class MarsRover
{
    private readonly string _initialState;
    private readonly Rover _rover;

    public MarsRover(string initialState)
    {
        _initialState = initialState;
        _rover = new Rover();
    }

    public string Execute(string commands)
    {
        // Parsing the command
        string[] states = _initialState.Split(':');
        int x = int.Parse(states[0]);
        int y = int.Parse(states[1]);
        string directionStringCommand = states[2];
        _rover._position = new Position(x, y);
        _rover._direction = DirectionFactory.CreateFrom(directionStringCommand);
        commands.ToCharArray().ToList().ForEach(c =>
        {
            if (c == 'M')
            {
                _rover.MoveForward();
            }
            else if (c == 'R')
            {
                _rover.TurnRight();
            }
            else if (c == 'L')
            {
                _rover.TurnLeft();
            }
        });
        return $"{_rover._position.X}:{_rover._position.Y}:{_rover._direction.AsStringCommand()}";
    }
}