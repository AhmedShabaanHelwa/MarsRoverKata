namespace MarsRover.Commands;

/// <summary>
/// Commands factory to create the proper concrete implementation of ICommand
/// </summary>
internal abstract class CommandsFactory
{
    /// <summary>
    /// Creates the proper concrete implementation of ICommand from a command character.
    /// </summary>
    /// <param name="commandCharacter">Command character.</param>
    /// <returns>Concrete implementation of the command.</returns>
    /// <exception cref="NotSupportedException">Thrown in case of not supported command.</exception>
    internal static ICommand CreatFromCharacter(char commandCharacter)
    {
        return commandCharacter switch
        {
            'M' => new MoveForwardCommand(),
            'R' => new TurnRightCommand(),
            'L' => new TurnLeftCommand(),
            _ => throw new NotSupportedException($"Command {commandCharacter} is not supported.")
        };
    }
}