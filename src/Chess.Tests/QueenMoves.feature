Feature: Queen Moves

Scenario Outline: A white queen can move diagonaly, vertically and horizontally
	Given A queen is placed at the initial position <InitialPosition>
	And The piece color is White
	When I ask for queen valid moves
	Then Moves to the positions <ValidPositions> are valid
	
	Examples:
	| InitialPosition | ValidPositions                                                 |
	| 36              | 27,18,45,54,63,72,81,16,26,46,56,66,76,86,37,38,35,34,33,32,31 |
	| 11              | 22,33,44,55,66,77,88,12,13,14,15,16,17,18,21,31,41,51,61,71,81 |

Scenario Outline: A black queen can not go outside board bounds
	Given A queen is placed at the initial position <InitialPosition>
	And The piece color is Black
	When I ask for queen valid moves
	Then Moves to the positions <InvalidPositions> are invalid
	
	Examples:
	| InitialPosition | InvalidPositions |
	| 88              | 89,99,98         |
