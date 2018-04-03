using System.Collections.Generic;
using Chess.Model;

namespace Chess
{
    public class PawnMoveExplorer : IMoveExplorer
    {
        public IEnumerable<Position> GetValidMovesForPosition(Position initialPosition, Color color)
        {
            return new List<Position>
            {
                new Position(initialPosition.File, initialPosition.Rank + 1)
            };
        }        
    }
}
