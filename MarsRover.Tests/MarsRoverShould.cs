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
    [InlineData("0:0:N", "0:1:N")] // North - From center
    [InlineData("5:2:N", "5:3:N")] // North - From non-center position
    [InlineData("7:3:E", "8:3:E")] // East
    [InlineData("9:5:W", "8:5:W")] // West
    [InlineData("2:6:S", "2:5:S")] // South
    internal void MoveForward(string initialPosition, string finalPosition)
    {
        // Arrange
        MarsRover marsRover = new(initialPosition);
        // Act
        string result = marsRover.Execute("M");
        // Assert
        result.Should().Be(finalPosition);
    }
}