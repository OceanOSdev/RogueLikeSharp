using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RogueLikeSharp
{
    /// <summary>
    /// Describes where on the map something is
    /// </summary>
    public struct Point
    {
        private int x;
        private int y;

        /// <summary>
        /// Initializes a new Point.
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="y">The Y component.</param>
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// The X component
        /// </summary>
        public int X
        {
            get { return x; }
        }

        /// <summary>
        /// The Y component
        /// </summary>
        public int Y
        {
            get { return y; }
        }

        /// <summary>
        /// Override of the addition operator.
        /// </summary>
        /// <param name="lhs">The left hand side.</param>
        /// <param name="rhs">The right hand side.</param>
        /// <returns>Returns the sum of the two points.</returns>
        public static Point operator +(Point lhs, Point rhs) => new Point(lhs.X + rhs.X, lhs.Y + rhs.Y);

        /// <summary>
        /// Override of the subtraction operator.
        /// </summary>
        /// <param name="lhs">The left hand side.</param>
        /// <param name="rhs">The right hand side.</param>
        /// <returns>Returns the difference of the two points.</returns>
        public static Point operator -(Point lhs, Point rhs) => new Point(lhs.X - rhs.X, lhs.Y - rhs.Y);

        /// <summary>
        /// Override of the multiplication operator.
        /// </summary>
        /// <param name="lhs">The left hand side.</param>
        /// <param name="rhs">The right hand side.</param>
        /// <returns>Returns the product of the two points.</returns>
        public static Point operator *(Point lhs, Point rhs) => new Point(lhs.X * rhs.X, lhs.Y * rhs.Y);

        /// <summary>
        /// Override of the division operator.
        /// </summary>
        /// <param name="lhs">The left hand side.</param>
        /// <param name="rhs">The right hand side.</param>
        /// <returns>Returns the quotient of the two points.</returns>
        /// <remarks>Uses integer division on the components.</remarks>
        /// <example>
        /// This sample shows how to use it:
        /// <code>
        /// Point a = new Point(5,8);
        /// Point b = new Point(2,4);
        /// Point c = a / b; // should return (1,2)
        /// </code>
        /// </example>
        public static Point operator /(Point lhs, Point rhs) => new Point(lhs.X / rhs.X, lhs.Y / rhs.Y);

        /// <summary>
        /// Override of the equality operator.
        /// </summary>
        /// <param name="lhs">The left hand side.</param>
        /// <param name="rhs">The right hand side.</param>
        /// <returns>True if both components are equal.</returns>
        public static bool operator ==(Point lhs, Point rhs) => lhs.X == rhs.X && lhs.Y == rhs.Y;

        /// <summary>
        /// Override of the not equal operator. (Or what ever it's called)
        /// </summary>
        /// <param name="lhs">The left hand side.</param>
        /// <param name="rhs">The right hand side.</param>
        /// <returns>True if one or neither components are equal.</returns>
        public static bool operator !=(Point lhs, Point rhs) => !(lhs.X == rhs.X && lhs.Y == rhs.Y);

        /// <summary>
        /// Indicates whether this instance and a specified object are equal.
        /// </summary>
        /// <param name="obj">The object to compare with the current instance.</param>
        /// <returns>true if obj and this instance are the same type and represent the same value; otherwise, false.</returns>
        public override bool Equals(object obj) => base.Equals(obj);

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A 32-bit signed integer that is the hash code for this instance.</returns>
        public override int GetHashCode() => base.GetHashCode();

        /// <summary>
        /// Returns a String representation of this object.
        /// </summary>
        /// <returns>A String representaion of this object.</returns>
        public override string ToString() => $"({X},{Y})";
    }
}