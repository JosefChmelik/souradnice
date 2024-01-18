using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_souradnice
{
    public class Coord : IEquatable<Coord>, IComparable<Coord>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coord(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double Size { get { return Math.Sqrt(X * X + Y * Y); } }
        public double Magnitude { get { return (X * X + Y * Y); } }

        public static bool operator <(Coord a, Coord b)
        {
            return a.Size < b.Size;
        }

        public static bool operator >(Coord a, Coord b)
        {
            return a.Size > b.Size;
        }
        public int CompareTo(Coord other)
        {
            if (this.Magnitude > other.Magnitude)
                return 1;
            else if (this.Magnitude < other.Magnitude)
                return -1;
            else
                return 0;
        }
        public bool Equals(Coord other)
        {
            if (other == null)
                return false;

            return this.X == other.X && this.Y == other.Y;
        }

        public static Coord CoordAddition(Coord a, Coord b)
        {
            int addedX = a.X + b.X;
            int addedY = a.Y + b.Y;
            Coord addedCord = new Coord(addedX, addedY);
            return addedCord;
        }

        public static Coord CoordMultiplication(Coord a, int i)
        {
            int multipliedX = a.X * i;
            int multipliedY = a.Y * i;
            Coord multipliedCoord = new Coord(multipliedX, multipliedY);
            return multipliedCoord;
        }
    }
}
