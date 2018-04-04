Feature: Rook Moves
<table margin='5'>
	<tr>
		<td>
			<img src ='./Board.png' alt='Board' width='200' height='200' />
		</td>
		<td>
		In order follow the chess game rules<br/>
		As a <b>Rook</b><br/>
		I have to respect some move rules
		</td>
	</tr>
</table>

@Rook
Scenario Outline: Rook can move vertically and horizontally
	<img src ='./Rook.png' alt='rook moves' width='200' height='200' />
	Given A rook is placed at the initial position <InitialPosition>
	And The piece color is White
	When I ask for rook valid moves
	Then Moves to the positions <ValidPositions> are valid
	
	Examples:
	| InitialPosition | ValidPositions                            |
	| 45              | 46,47,48,15,25,35,41,42,43,44,55,65,75,85 |
	| 27              | 28,17,21,22,23,24,25,26,37,47,57,67,77,87 |
	| 72              | 78,77,76,75,74,73,71,82,12,22,32,42,52,62 |
	| 18              | 28,38,48,58,68,78,88,17,16,15,14,13,12,11 |

@Rook
Scenario Outline: Rook can not go outside board bounds
	Given A rook is placed at the initial position <InitialPosition>
	And The piece color is Black
	When I ask for rook valid moves
	Then Moves to the positions <InvalidPositions> are invalid

	Examples:
	| InitialPosition | InvalidPositions |
	| 88              | 08,98,19,10      |
	| 26              | 08,98,19,10      |
	| 74              | 08,98,19,10      |
	| 81              | 08,98,19,10      |