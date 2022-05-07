using FluentAssertions;
using Xunit;

namespace MarsRover.Tests;
/// <remarks>
/// classes names follow Should/ShouldNot convention
/// </remarks>
public class MarsRoverShould
{
    [Fact]
    public void PrintInitialStateFromCenterPosition()
    {
        // Arrange - (G)iven - To arrange your setup for the test
        var marsRover = new MarsRover(initialState: "0:0:N");
        // Act - (W)hen - To Act on your unit
        var result = marsRover.Execute(commands: "");
        // Assert - (T)hat - To verify your test.
        result.Should().Be("0:0:N");
    }
    [Fact]
    public void PrintInitialStateFromNoneCentericPosition()
    {
        // Arrange - (G)iven - To arrange your setup for the test
        var marsRover = new MarsRover(initialState: "4:2:W");
        // Act - (W)hen - To Act on your unit
        var result = marsRover.Execute(commands: "");
        // Assert - (T)hat - To verify your test.
        result.Should().Be("4:2:W");
    }
}
