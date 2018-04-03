using System.Collections.Generic;
using Chess.Model;

namespace Chess
{
    public class RookMoveExplorer : IMoveExplorer
    {
        public IEnumerable<Position> GetValidMovesForPosition(Position initialPosition, Color color)
        {
            var validPositions = new List<Position>();

            for (int currentFile = Board.MinFile; currentFile < initialPosition.File; currentFile++)
            {
                validPositions.Add(new Position(currentFile, initialPosition.Rank));
            }

            for (int currentFile = initialPosition.File + 1; currentFile <= Board.MaxFile; currentFile++)
            {
                validPositions.Add(new Position(currentFile, initialPosition.Rank));
            }

            for (int currentRank = Board.MinRank; currentRank < initialPosition.Rank; currentRank++)
            {
                validPositions.Add(new Position(initialPosition.File, currentRank));
            }

            for (int currentRank = initialPosition.Rank + 1; currentRank <= Board.MaxRank; currentRank++)
            {
                validPositions.Add(new Position(initialPosition.File, currentRank));
            }

            return validPositions;
        }
    }
}
