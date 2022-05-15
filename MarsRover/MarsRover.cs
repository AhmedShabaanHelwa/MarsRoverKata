﻿using MarsRover.Directions;

namespace MarsRover;

public class MarsRover
{
    private readonly string _initialState;
    private IDirection? _direction;
    private Position? _position;

    public MarsRover(string initialState)
    {
        _initialState = initialState;
    }

    public string Execute(string commands)
    {
        // Parsing the command
        string[] states = _initialState.Split(':');
        int x = int.Parse(states[0]);
        int y = int.Parse(states[1]);
        string directionStringCommand = states[2];
        _position = new Position(x, y);
        _direction = DirectionFactory.CreateFrom(directionStringCommand);
        // Forward
        if (commands == "M")
        {
            _position = _direction.MoveForward(_position);
        }
        else if (commands == "R")
        {
            _direction = _direction.ToRight();
        }

        return $"{_position.X}:{_position.Y}:{_direction.AsStringCommand()}";
    }
}