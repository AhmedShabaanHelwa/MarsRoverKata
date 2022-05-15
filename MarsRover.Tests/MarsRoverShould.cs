using FluentAssertions;
using Xunit;

namespace MarsRover.Tests;
/// <remarks>
/// classes names follow Should/ShouldNot convention
/// </remarks>
public class MarsRoverShould
{
    [Theory]
    [InlineData("0:0:N")] // Initial state: The center.
    [InlineData("4:2:w")] // Non-centric initial state.
    public void PrintInitialState(string initialState)
    {
        // Arrange - (G)iven - To arrange your setup for the test
        var marsRover = new MarsRover(initialState: initialState);
        // Act - (W)hen - To Act on your unit
        var result = marsRover.Execute(commands: "");
        // Assert - (T)hat - To verify your test.
        result.Should().Be(initialState);
    }

    [Theory]
    [InlineData("0:0:N", "0:1:N")] // Towards North, from the center.
    [InlineData("3:6:N", "3:7:N")] // Towards North, from a random point
    [InlineData("3:6:W", "2:6:W")] // Towards West
    [InlineData("3:6:E", "4:6:E")] // Towards East
    [InlineData("3:6:S", "3:5:S")] // Towards South
    public void MoveForward(string initialState, string expectedFinalState)
    {
        // Arrange
        var marsRover = new MarsRover(initialState);
        // Act
        var result = marsRover.Execute(commands: "M");
        // Assert
        result.Should().Be(expectedFinalState);
    }
    
    [Theory]
    [InlineData("0:0:N", "R", "0:1:E")] // From North, Should be East.
    public void TurnRight(string initialState, string commands ,string expectedFinalState)
    {
        // Arrange
        var marsRover = new MarsRover(initialState);
        // Act
        var result = marsRover.Execute(commands: commands);
        // Assert
        result.Should().Be(expectedFinalState);
    }
}
