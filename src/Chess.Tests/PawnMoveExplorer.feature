Feature: Pawn move explorer

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

Scenario Outline: A black pawn can move one step forward
	Given A pawn is placed at the initial position <InitialPosition>
	And The piece color is Black
	When I ask for pawn valid moves
	Then Moves to the positions <ValidPositions> are valid
	
	Examples:
	| InitialPosition | ValidPositions |
	| 34              | 33             |
	| 17              | 16             |
	| 74              | 73             |

Scenario Outline: A white pawn placed on his initial rank can move one or two step forward
	Given A pawn is placed at the initial position <InitialPosition>
	And The piece color is White
	When I ask for pawn valid moves
	Then Moves to the positions <ValidPositions> are valid
	
	Examples:
	| InitialPosition | ValidPositions |
	| 22              | 23,24          |
	| 52              | 53,54          |
	| 82              | 83,84          |

Scenario Outline: A white pawn placed on the black initial rank can't move one or two step forward
	Given A pawn is placed at the initial position <InitialPosition>
	And The piece color is White
	When I ask for pawn valid moves
	Then Moves to the positions <InvalidPositions> are invalid

	Examples:
	| InitialPosition | InvalidPositions |
	| 27              | 25,26,29         |
	| 67              | 65,66,69         |

Scenario Outline: A pawn can't move backward
	Given A pawn is placed at the initial position <InitialPosition>
	And The piece color is White
	When I ask for pawn valid moves
	Then Moves to the positions <InvalidPositions> are invalid

	Examples:
	| InitialPosition | InvalidPositions |
	| 55              | 54,53,52,51      |
	| 22              | 21               |

Scenario Outline: Pawn can not go outside board bounds when it is close to the border
	Given A pawn is placed at the initial position <InitialPosition>
	And The piece color is White
	When I ask for pawn valid moves
	Then Moves to the positions <ValidPositions> are valid
	
	Examples:
	| InitialPosition | ValidPositions |
	| 28              |                |
	| 38              |                |