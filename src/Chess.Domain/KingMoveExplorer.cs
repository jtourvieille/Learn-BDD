using System.Collections.Generic;
using System.Linq;
using Chess.Model;

namespace Chess
{
    public class KingMoveExplorer : IMoveExplorer
    {
        public IEnumerable<Position> GetValidMovesForPosition(Position initialPosition, Color color)
        {
            var candidatesPositions = GetCandidatesPositions(initialPosition);

            return CheckForValidPositions(candidatesPositions).ToList();
        }

        private IEnumerable<Position> CheckForValidPositions(IEnumerable<Position> candidatesPositions)
        {
            foreach (var candidatesPosition in candidatesPositions)
            {
                if (candidatesPosition.Rank >= Board.MinRank && candidatesPosition.Rank <= Board.MaxRank &&
                    candidatesPosition.File >= Board.MinFile && candidatesPosition.File <= Board.MaxFile)
                {
                    yield return candidatesPosition;
                }
            }
        }

        private IEnumerable<Position> GetCandidatesPositions(Position initialPosition)
        {
            yield return new Position(initialPosition.File - 1, initialPosition.Rank - 1);
            yield return new Position(initialPosition.File - 1, initialPosition.Rank + 1);
            yield return new Position(initialPosition.File + 1, initialPosition.Rank - 1);
            yield return new Position(initialPosition.File + 1, initialPosition.Rank + 1);
            yield return new Position(initialPosition.File - 1, initialPosition.Rank);
            yield return new Position(initialPosition.File + 1, initialPosition.Rank);
            yield return new Position(initialPosition.File, initialPosition.Rank - 1);
            yield return new Position(initialPosition.File, initialPosition.Rank + 1);
        }
    }
}
