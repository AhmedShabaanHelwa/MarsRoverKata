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
                _position = _direction.MoveForward(_position);
            }
            else if (c == 'R')
            {
                _direction = _direction.ToRight();
            }
            else if (c == 'L')
            {
                _direction = _direction.ToLeft();
            }
        });
        return $"{_position.X}:{_position.Y}:{_direction.AsStringCommand()}";
    }
}