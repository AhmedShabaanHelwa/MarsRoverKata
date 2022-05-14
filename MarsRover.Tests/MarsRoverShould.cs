using FluentAssertions;
using Xunit;

namespace MarsRover.Tests;

public class MarsRoverShould
{
    [Theory]
    [InlineData("0:0:N")] // Centric position
    [InlineData("6:4:W")] //
    internal void PrintInitialState(string initialState)
    {
        // Arrange
        MarsRover marsRover = new MarsRover(initialState);
        // Act
        var result = marsRover.Execute("");
        // Assert
        result.Should().Be(initialState);
    }
}