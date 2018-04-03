using System.Collections.Generic;
using Chess.Model;

namespace Chess
{
    public interface IMoveExplorer
    {
        IEnumerable<Position> GetValidMovesForPosition(Position initialPosition, Color color);
    }
}
