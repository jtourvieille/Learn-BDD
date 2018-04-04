using System.Collections.Generic;
using Chess.Model;

namespace Chess
{
    public class QueenMoveExplorer : IMoveExplorer
    {
        public IEnumerable<Position> GetValidMovesForPosition(Position initialPosition, Color color)
        {
            var bishopMoveExplorer = new BishopMoveExplorer();
            var rookMoveExplorer = new RookMoveExplorer();

            var validMoves = new List<Position>();

            validMoves.AddRange(bishopMoveExplorer.GetValidMovesForPosition(initialPosition, color));
            validMoves.AddRange(rookMoveExplorer.GetValidMovesForPosition(initialPosition, color));

            return validMoves;
        }
    }
}
