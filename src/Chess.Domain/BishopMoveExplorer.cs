using System.Collections.Generic;
using Chess.Model;

namespace Chess
{
    public class BishopMoveExplorer : IMoveExplorer
    {
        public IEnumerable<Position> GetValidMovesForPosition(Position initialPosition, Color color)
        {
            var validPositions = new List<Position>();

            validPositions.AddRange(this.GetUpLeftDirectionValidMoves(initialPosition));
            validPositions.AddRange(this.GetUpRightDirectionValidMoves(initialPosition));
            validPositions.AddRange(this.GetDownLeftDirectionValidMoves(initialPosition));
            validPositions.AddRange(this.GetDownRightDirectionValidMoves(initialPosition));

            return validPositions;
        }

        private IEnumerable<Position> GetDownRightDirectionValidMoves(Position initialPosition)
        {
            int file = initialPosition.File - 1;
            int rank = initialPosition.Rank + 1;

            for (; file >= Board.MinFile && rank <= Board.MaxRank; file--, rank++)
            {
                yield return new Position(file, rank);
            }
        }

        private IEnumerable<Position> GetDownLeftDirectionValidMoves(Position initialPosition)
        {
            int file = initialPosition.File - 1;
            int rank = initialPosition.Rank - 1;

            for (; file >= Board.MinFile && rank >= Board.MinRank; file--, rank--)
            {
                yield return new Position(file, rank);
            }
        }

        private IEnumerable<Position> GetUpRightDirectionValidMoves(Position initialPosition)
        {
            int file = initialPosition.File + 1;
            int rank = initialPosition.Rank + 1;

            for (; file <= Board.MaxFile && rank <= Board.MaxRank; file++, rank++)
            {
                yield return new Position(file, rank);
            }
        }

        private IEnumerable<Position> GetUpLeftDirectionValidMoves(Position initialPosition)
        {
            int file = initialPosition.File + 1;
            int rank = initialPosition.Rank - 1;

            for (; file <= Board.MaxFile && rank >= Board.MinRank; file++, rank--)
            {
                yield return new Position(file, rank);
            }
        }
    }
}
