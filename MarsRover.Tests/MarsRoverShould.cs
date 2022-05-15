using FluentAssertions;
using Xunit;

namespace MarsRover.Tests;

/// <remarks>
/// classes names follow Should/ShouldNot convention
/// </remarks>
public class MarsRoverShould
{
    [Theory]
    /* Feature 1: Initial State commands (Empty Command) */
    [InlineData("0:0:N", "", "0:0:N")] // Initial state: The center.
    [InlineData("4:2:w", "", "4:2:w")] // Non-centric initial state.
    /* Feature 2: Move forward */
    [InlineData("0:0:N", "M", "0:1:N")] // Towards North, from the center.
    [InlineData("3:6:N", "M", "3:7:N")] // Towards North, from a random point
    [InlineData("3:6:W", "M", "2:6:W")] // Towards West
    [InlineData("3:6:E", "M", "4:6:E")] // Towards East
    [InlineData("3:6:S", "M", "3:5:S")] // Towards South
    /* Feature 3: Turn Right */
    [InlineData("0:0:N", "R", "0:0:E")] // From North, Should be East.
    public void ExecuteCommands(string initialState, string commands, string expectedFinalState)
    {
        // Arrange
        var marsRover = new MarsRover(initialState);
        // Act
        var result = marsRover.Execute(commands: commands);
        // Assert
        result.Should().Be(expectedFinalState);
    }
}