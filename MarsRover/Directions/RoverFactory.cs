namespace MarsRover.Directions;
/// <summary>
/// Rover factory to create a rover
/// </summary>
internal abstract class RoverFactory
{
    /// <summary>
    /// Factory method to create a rover from its initial state.
    /// </summary>
    /// <param name="initialState">initial state of a rover.
    /// It must be of the format "x:y:direction"</param>
    /// <returns>New instance of the rover</returns>
    internal static Rover CreatFromInitialState(string initialState)
    {
        string[] states = initialState.Split(':');
        int x = int.Parse(states[0]);
        int y = int.Parse(states[1]);
        string directionStringCommand = states[2];
        Position position = new Position(x, y);
        IDirection direction = DirectionFactory.CreateFrom(directionStringCommand);

        return new Rover(position: position, direction: direction);
    }
}