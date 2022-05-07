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
        var result = marsRover.Execute(commands: "");
        // Assert - (T)hat - To verify your test.
        result.Should().Be(intialState);
    }
}
