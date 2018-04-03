using System;
using System.Collections.Generic;
using Chess.Model;

namespace Chess
{
    public class PawnMoveExplorer : IMoveExplorer
    {
        private const int WhiteStartRank = 2;
        private const int BlackStartRank = 7;

        public IEnumerable<Position> GetValidMovesForPosition(Position initialPosition, Color color)
        {
            return GetValidMoves(initialPosition, color);
        }

        private IEnumerable<Position> GetValidMoves(Position initialPosition, Color color)
        {
            switch (color)
            {
                case Color.White:
                    return GetWhiteValidMoves(initialPosition, WhiteStartRank);
                case Color.Black:
                    return GetBlackValidMoves(initialPosition, BlackStartRank);
                default:
                    throw new Exception($"This color is not handled {color}");
            }
        }

        private IEnumerable<Position> GetWhiteValidMoves(Position initialPosition, int whiteStartRank)
        {
            var validPositions = new List<Position>();

            if (initialPosition.Rank + 1 < Board.MaxRank)
            {
                validPositions.Add(new Position(initialPosition.File, initialPosition.Rank + 1));
            }

            if (initialPosition.Rank == whiteStartRank)
            {
                validPositions.Add(new Position(initialPosition.File, initialPosition.Rank + 2));
            }

            return validPositions;
        }

        private IEnumerable<Position> GetBlackValidMoves(Position initialPosition, int blackStartRank)
        {
            var validPositions = new List<Position>();

            if (initialPosition.Rank - 1 > Board.MinRank)
            {
                validPositions.Add(new Position(initialPosition.File, initialPosition.Rank - 1));
            }

            if (initialPosition.Rank == blackStartRank)
            {
                validPositions.Add(new Position(initialPosition.File, initialPosition.Rank - 2));
            }

            return validPositions;
        }
    }
}
