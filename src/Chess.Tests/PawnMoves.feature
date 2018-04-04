Feature: Pawn Moves

Scenario Outline: A white pawn can move one step forward
	Given A pawn is placed at the initial position <InitialPosition>
	And The piece color is White
	When I ask for pawn valid moves
	Then Moves to the positions <ValidPositions> are valid
	
	Examples:
	| InitialPosition | ValidPositions |
	| 44              | 45             |
	| 43              | 44             |
	| 86              | 87             |