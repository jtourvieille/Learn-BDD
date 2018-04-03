using System;

namespace Chess.Model
{
    public class Position : IEquatable<Position>
    {
        public Position(int file, int rank)
        {
            this.File = file;
            this.Rank = rank;
        }

        public int File { get; }

        public int Rank { get; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Position) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (File * 397) ^ Rank;
            }
        }

        public bool Equals(Position other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return File == other.File && Rank == other.Rank;
        }
    }
}
