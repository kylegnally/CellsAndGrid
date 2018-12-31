# CellsAndGrid
A program to create a Grid object filled with Cell objects. Each Cell will contain a Position, Above, ToRight, Below, and ToLeft property.

## Author

Kyle Nally

## Description

This program creates a square Grid object with [0,0] at the upper left corner. The length of each side is specified by the user, 
who is asked where they wish to start in terms of X and Y (note that X moves left to right, but Y moves TOP to BOTTOM). 

The Grid object is filled with Cell objects in a two-dimensional array. Each Cell has a Contents property. The user's location is 
represented by an asterisk and the user is able to use the arrow keys to move around the Grid. At each move, the Grid redraws and 
displays the user's new location. If the user tries to move onto a wall (%) the program stops them from doing so and displays a message
telling them they cannot move any further. 

The user is able to press the Escape key (ESC) to exit the program.

## Classes

# Grid
This class models the "game board". This class fills itself with Cell objects in a two-dimensional array. 

# Cell
This class models a single space on the board. Each Cell has the following properties:

|  Property |                   Purpose                     |
|-----------|-----------------------------------------------|
| XPosition | The X position of the Cell on the Grid.       | 
| YPosition | The Y position of the Cell on the Grid.       |
| Selected  | If true, draws an asterisk (*) in the Cell.   |
| Visited   | If true, erases the default dash (-) when the |
|           | user moves away from the Cell.                |
| EdgeCell  | If true, displays a percent sign (%) in the   | 
|           | Cell.                                         |
| Contents  | Contains the contents of the Cell as a string.|

# Apple
This class will contain information about the Apples for a Snake Game. This feature is not yet implemented.

# IGenericQueue
An interface for a generic Queue.

# GenericQueue
A generic queue in the style of a linked list. This will be used to add and remove segments from the snake when it eats an apple or
hits an enemy. This feature is not yet implemented.

### Notes

Since we have a Grid with Cells and a Player which can move about it

## Known Problems
# Separation of concerns 
The Grid object contains a DrawGrid function. It shouldn't. All things related to putting anything on the screen
should properly be the concern of a user interface (which does not yet exist). Before going any further, I should create a user 
interface class that will draw the Grid object and write all the prompts to the screen.

# Write to file
The program currently prompts the user to press the W key if they wish to write the current state of the board to a file. This does
not yet work (it crashes the program) because access is denied to the debug folder. This should be fixed ASAP.
