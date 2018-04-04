Feature: Knight Moves
<table margin='5'>
	<tr>
		<td>
			<img src ='./Board.png' alt='Board' width='200' height='200' />
		</td>
		<td>
		In order follow the chess game rules<br/>
		As a <b>Knight</b><br/>
		I have to respect some move rules
		</td>
	</tr>
</table>

@Knight
Scenario Outline: Knight can not go outside board bounds when it is close to the borders
	Given A knight is placed at the initial position <InitialPosition>
	And The piece color is White
	When I ask for knight valid moves
	Then Moves to the positions <ValidPositions> are valid
	
	Examples:
	| InitialPosition | ValidPositions |
	| 18              | 37,26          |
	| 38              | 17,26,46,57    |
	| 83              | 71,62,64,75    |
	| 22              | 14,34,43,41    |

@Knight
Scenario Outline: Knight can move two step in a direction, then one step in the orthogonal direction
	<img src ='./Knight.png' alt='knight moves' width='200' height='200' />
	Given A knight is placed at the initial position <InitialPosition>
	And The piece color is White
	When I ask for knight valid moves
	Then Moves to the positions <ValidPositions> are valid
	
	Examples:
	| InitialPosition | ValidPositions          |
	| 44              | 23,25,36,56,65,63,52,32 |
	| 43              | 22,51,22,24,35,55,64,62 |
