Feature: King Moves
<table margin='5'>
	<tr>
		<td>
			<img src ='./Board.png' alt='Board' width='200' height='200' />
		</td>
		<td>
		In order follow the chess game rules<br/>
		As a <b>King</b><br/>
		I have to respect some move rules
		</td>
	</tr>
</table>

@King
Scenario Outline: King can move one step anywhere around him
	<img src ='./King.png' alt='king moves' width='200' height='200' />
	Given A king is placed at the initial position <InitialPosition>
	And The piece color is White
	When I ask for king valid moves
	Then Moves to the positions <ValidPositions> are valid
	
	Examples:
	| InitialPosition | ValidPositions          |
	| 67              | 57,58,68,78,77,76,66,56 |
	| 27              | 17,18,28,38,37,36,26,16 |

@King
Scenario Outline: King can not go outside board bounds when it is close to the borders
	Given A king is placed at the initial position <InitialPosition>
	And The piece color is Black
	When I ask for king valid moves
	Then Moves to the positions <InvalidPositions> are invalid

	Examples:
	| InitialPosition | InvalidPositions |
	| 13              | 02,03,04         |
	| 68              | 49,59,69         |
	| 87              | 98,97,96         |
	| 41              | 30,40,50         |
	| 11              | 02,01,00,10,20   |