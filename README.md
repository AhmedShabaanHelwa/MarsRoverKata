# Mars Rover Kata
A classic TDD, object-oriented and refactoring exercise. Kata means an exercise, and [This kata](https://katalyst.codurance.com/simple-mars-rover) is provided by Codurance communit.

## Requirements
A squad of robotic rovers are to be landed by NASA on a plateau on Mars.

This plateau, which is curiously rectangular, must be navigated by the rovers so that their onboard cameras can get a complete view of the surrounding terrain to send back to Earth.

*Your task is to develop an API that moves the rovers around on the plateau.*

In this API, the plateau is represented as a 10x10 grid, and a rover has state consisting of two parts:

 - its position on the grid (represented by an X,Y coordinate pair)
 - the compass direction it's facing (represented by a letter, one of N, S, E, W)
 - the starting position of the rover is 0:0:N
 
 ### Input
 The input to the program is a string of one-character move commands:

 - L and R rotate the direction the rover is facing
 - M moves the rover one grid square forward in the direction it is currently facing
 - If a rover reaches the end of the plateau, it wraps around the end of the grid.
 ### Output
 The program's output is the final position of the rover after all the move commands have been executed. The position is represented as a coordinate pair and a direction, joined by colons to form a string. For example: a rover whose position is 2:3:W is at square (2,3), facing west.
 
 ## Comment about commits
 Commits were considered to be single-change and self-contained. Tracking of history gives an insight of knowledge development.

 ## TDD approch
 Classic TDD was followed. **Red, Green, Refactor**. Trangulation, the mini-cycle of TDD, was applied as well so that covering all possible cases.
 Tests follow the convention **Should** and **ShouldNot**.
 
 ## Design Patterns
 1. Command design pattern: is the main pattern.
 2. Factory design pattern: Is used to create objects of Direction, Position and Command.
 3. State/Strategy is used to solve switch-statement code smell (Lack of polymophism).
 
 ## Code smells introduced during the design
 1. Primitive obsession.
 2. Switch-statement OOP-abuser, which indicates lack of polymorphism.
 3. Inline method.

## Design and clean code principles
1. Readability, Comments, Self-explanining and Consistency for each tiny detail are the first priority.
2. DRY for sure!
3. Single Responsibility Principle. Every class has its own responsibility and has a single reason to change.
4. Separation of concern is widely used. Each of Rover, Direction, Command and others are packed together with smooth interactions.
5. Enacabsulation is never being violated. All fields are getten through getters, for example.
6. Immutability is highly considered. I do not change our rover state intentionally.
7. Exceptions are thrown precisely.

## Thank you!
I would like to thank @Pierre-Jean Baraud for his great efforts and neat explanation. This kata will not appear nicely without his tutorial.
