using System.Collections;
using System.Collections.Generic;
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
    [ClassData(typeof(InitialStateTestCases))]
    /* Feature 2: Move forward */
    [ClassData(typeof(MoveForwardTestCases))]
    /* Feature 3: Turn Right */
    [ClassData(typeof(TurnRightTestCases))]
    /* Feature 4: Turn Left */
    [ClassData(typeof(TurnLeftCommandTestCases))]
    /* Feature 5: Multiple Commands */
    [ClassData(typeof(MultipleCommandsTestCases))]
    public void ExecuteCommands(string initialState, string commands, string expectedFinalState)
    {
        // Arrange
        var marsRover = new MarsRover(initialState);
        // Act
        var result = marsRover.Execute(commandsString: commands);
        // Assert
        result.Should().Be(expectedFinalState);
    }
}