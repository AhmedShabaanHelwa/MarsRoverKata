using FluentAssertions;
using Xunit;

namespace MarsRover.Tests;
/// <remarks>
/// classes names follow Should/ShouldNot convention
/// </remarks>
public class MarsRoverShould
{
    [Theory]
    [InlineData("0:0:N")]
    [InlineData("4:2:w")]
    public void PrintInitialState(string intialState)
    {
        // Arrange - (G)iven - To arrange your setup for the test
        var marsRover = new MarsRover(initialState: intialState);
        // Act - (W)hen - To Act on your unit
        var result = marsRover.Execute(command: "");
        // Assert - (T)hat - To verify your test.
        result.Should().Be(intialState);
    }

    [Theory]
    [InlineData("0:0:N", "0:1:N")]
    [InlineData("3:6:N", "3:7:N")]
    public void MoveFoward(string initialState, string finalState)
    {
        // Arrange
        var marsRover = new MarsRover(initialState);
        // Act
        var result = marsRover.Execute(command: "M");
        // Assert
        result.Should().Be(finalState); // Shold be on direction in Y-Axis
    }
}
