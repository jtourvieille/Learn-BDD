Feature: Bishop Moves

Scenario Outline: A white bishop can move diagonaly
	Given A bishop is placed at the initial position <InitialPosition>
	And The piece color is White
	When I ask for bishop valid moves
	Then Moves to the positions <ValidPositions> are valid
	
	Examples:
	| InitialPosition | ValidPositions                   |
	| 33              | 22,11,44,55,66,77,88,24,15,42,51 |
	| 88              | 77,66,55,44,33,22,11             |

Scenario Outline: A black bishop can not go outside board bounds
	Given A bishop is placed at the initial position <InitialPosition>
	And The piece color is Black
	When I ask for bishop valid moves
	Then Moves to the positions <InvalidPositions> are invalid
	
	Examples:
	| InitialPosition | InvalidPositions |
	| 18              | 09,29,07         |