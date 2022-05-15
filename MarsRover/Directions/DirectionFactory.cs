namespace MarsRover.Directions;

public abstract class DirectionFactory
{
    public static IDirection CreateFrom(string direction)
    {
        return direction.ToLower() switch
        {
            "n" => new North(),
            "s" => new South(),
            "e" => new East(),
            "w" => new West(),
            _ => throw new NotSupportedException($"{direction} direction is not supported")
        };
    }
}