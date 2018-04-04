using System;
using System.Collections.Generic;
using Chess.Model;

namespace Chess
{
    public class KnightMoveExplorer : IMoveExplorer
    {
        private readonly List<Func<Position, Position>> validPositionsFunction;

        public KnightMoveExplorer()
        {
            validPositionsFunction = new List<Func<Position, Position>>
            {
                GetTwoUpOneLeftPosition,
                GetTwoUpOneRightPosition,
                GetTwoLeftOneUpPosition,
                GetTwoLeftOneDownPosition,
                GetTwoDownOneLeftPosition,
                GetTwoDownOneRightPosition,
                GetTwoRightOneUpPosition,
                GetTwoRightOneDownPosition
            };
        }

        public IEnumerable<Position> GetValidMovesForPosition(Position initialPosition, Color color)
        {
            var validPositions = new List<Position>();

            foreach (var oneValidPositionFunction in validPositionsFunction)
            {
                var position = oneValidPositionFunction(initialPosition);

                if (position != null)
                {
                    validPositions.Add(position);
                }
            }

            return validPositions;
        }

        private Position GetTwoRightOneDownPosition(Position initialPosition)
        {
            if (initialPosition.File + 2 <= Board.MaxFile && initialPosition.Rank - 1 >= Board.MinRank)
            {
                return new Position(initialPosition.File + 2, initialPosition.Rank - 1);
            }

            return null;
        }

        private Position GetTwoRightOneUpPosition(Position initialPosition)
        {
            if (initialPosition.File + 2 <= Board.MaxFile && initialPosition.Rank + 1 <= Board.MaxRank)
            {
                return new Position(initialPosition.File + 2, initialPosition.Rank + 1);
            }

            return null;
        }

        private Position GetTwoDownOneRightPosition(Position initialPosition)
        {
            if (initialPosition.Rank - 2 >= Board.MinRank && initialPosition.File + 1 <= Board.MaxFile)
            {
                return new Position(initialPosition.File + 1, initialPosition.Rank - 2);
            }

            return null;
        }

        private Position GetTwoDownOneLeftPosition(Position initialPosition)
        {
            if (initialPosition.Rank - 2 >= Board.MinRank && initialPosition.File - 1 >= Board.MinFile)
            {
                return new Position(initialPosition.File - 1, initialPosition.Rank - 2);
            }

            return null;
        }

        private Position GetTwoLeftOneDownPosition(Position initialPosition)
        {
            if (initialPosition.File - 2 >= Board.MinFile && initialPosition.Rank - 1 >= Board.MinRank)
            {
                return new Position(initialPosition.File - 2, initialPosition.Rank - 1);
            }

            return null;
        }

        private Position GetTwoUpOneLeftPosition(Position initialPosition)
        {
            if (initialPosition.File - 1 >= Board.MinFile && initialPosition.Rank + 2 <= Board.MaxRank)
            {
                return new Position(initialPosition.File - 1, initialPosition.Rank + 2);
            }

            return null;
        }

        private Position GetTwoUpOneRightPosition(Position initialPosition)
        {
            if (initialPosition.File + 1 <= Board.MaxFile && initialPosition.Rank + 2 <= Board.MaxRank)
            {
                return new Position(initialPosition.File + 1, initialPosition.Rank + 2);
            }

            return null;
        }

        private Position GetTwoLeftOneUpPosition(Position initialPosition)
        {
            if (initialPosition.File - 2 >= Board.MinFile && initialPosition.Rank + 1 <= Board.MaxRank)
            {
                return new Position(initialPosition.File - 2, initialPosition.Rank + 1);
            }

            return null;
        }
    }
}
