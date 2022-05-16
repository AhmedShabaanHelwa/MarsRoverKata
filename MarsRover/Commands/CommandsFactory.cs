namespace MarsRover.Commands;

internal abstract class CommandsFactory
{
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