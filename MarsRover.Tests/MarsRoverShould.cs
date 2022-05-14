using FluentAssertions;
using Xunit;

namespace MarsRover.Tests;

public class MarsRoverShould
{
    [Theory]
    [InlineData("0:0:N")] // Centric position
    [InlineData("6:4:W")] // Non-Centric Position
    internal void PrintInitialState(string initialState)
    {
        // Arrange
        MarsRover marsRover = new MarsRover(initialState);
        // Act
        var result = marsRover.Execute("");
        // Assert
        result.Should().Be(initialState);
    }

    [Theory]
    [InlineData("0:0:N")]
    internal void MoveForward(string initialPosition)
    {
        // Arrange
        MarsRover marsRover = new(initialPosition);
        // Act
        string result = marsRover.Execute("M");
        // Assert
        result.Should().Be("0:1:N");
    }
}