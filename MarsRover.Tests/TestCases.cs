using System.Collections;
using System.Collections.Generic;

namespace MarsRover.Tests;
/// <summary>
/// Feature 1: Initial State commands (Empty Command) test cases.
/// </summary>
internal class InitialStateTestCases : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { "0:0:N", "", "0:0:N"}; // Initial state: The center.  
        yield return new object[] { "4:2:W", "", "4:2:W"}; // Non-centric initial state.  
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

/// <summary>
/// Feature 2: Move forward test cases.
/// </summary>
internal class MoveForwardTestCases : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] {"0:0:N", "M", "0:1:N"}; // Towards North, from the center.        
        yield return new object[] {"3:6:N", "M", "3:7:N"}; // Towards North, from a random point     
        yield return new object[] {"3:6:W", "M", "2:6:W"}; // Towards West                           
        yield return new object[] {"3:6:E", "M", "4:6:E"}; // Towards East                           
        yield return new object[] {"3:6:S", "M", "3:5:S"}; // Towards South                          
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

/// <summary>
/// Feature 3: Turn Right test cases.
/// </summary>
internal class TurnRightTestCases : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] {"0:0:N", "R", "0:0:E"}; // From North, Should be East.
        yield return new object[] {"7:3:E", "R", "7:3:S"}; // From East, Should be South.
        yield return new object[] {"7:3:S", "R", "7:3:W"}; // From South. Should be West.
        yield return new object[] {"7:3:W", "R", "7:3:N"}; // From West, Should be North.
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

/// <summary>
/// Feature 4: Turn Left test cases.
/// </summary>
internal class TurnLeftCommandTestCases : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
         yield return new object[] { "0:0:N", "L", "0:0:W" }; // From North, Should be West.
         yield return new object[] { "7:3:E", "L", "7:3:N" }; // From East, Should be North.
         yield return new object[] { "7:3:S", "L", "7:3:E" }; // From South. Should be East.
         yield return new object[] { "7:3:W", "L", "7:3:S" }; // From West, Should be South.
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

/// <summary>
/// Feature 5: Multiple Commands test cases.
/// </summary>
internal class MultipleCommandsTestCases : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { "7:3:W", "LL", "7:3:E" };           // Two Turns to right.
        yield return new object[] { "1:1:S", "MLMLMRMMMLL", "5:1:W" };  // Movements and both turning to left and right.
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}