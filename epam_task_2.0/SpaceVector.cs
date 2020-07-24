using System;

namespace SpaceVector
{
    /// <summary>
    /// Vector in space
    /// </summary>
    public class SpaceVector
    {
        private double _x;
        private double _y;
        private double _z;


        public double X { get => _x; set => _x = value; }
        public double Y { get => _y; set => _y = value; }
        public double Z { get => _z; set => _z = value; }



        public SpaceVector(double x, double y, double z)
        {
            this._x = x;
            this._y = y;
            this._z = z;
        }

        /// <summary>
        /// Аddition
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>New vector, sum of vector a and b</returns>
        public static SpaceVector operator +(SpaceVector a, SpaceVector b) => new SpaceVector(a.X + b.X,
                                                                                              a.Y + b.Y,
                                                                                              a.Z + b.Z);


        /// <summary>
        /// Vector direction change sign
        /// </summary>
        /// <param name="a"></param>
        /// <returns>Оpposite vector</returns>
        //
        public static SpaceVector operator -(SpaceVector a) => new SpaceVector(-a.X,
                                                                               -a.Y,
                                                                               -a.Z);


        /// <summary>
        /// Increment
        /// </summary>
        /// <param name="a"></param>
        /// <returns>Vector after increment</returns>
        public static SpaceVector operator ++(SpaceVector a) => new SpaceVector(++a.X,
                                                                                ++a.Y,
                                                                                ++a.Z);


        /// <summary>
        /// Decrement
        /// </summary>
        /// <param name="a"></param>
        /// <returns>Vector after decrement</returns>
        public static SpaceVector operator --(SpaceVector a) => new SpaceVector(--a.X,
                                                                                --a.Y,
                                                                                --a.Z);



        /// <summary>
        /// Vector multiplication
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>New vector, product of vectors a and b</returns>
        public static SpaceVector operator *(SpaceVector a, SpaceVector b) => new SpaceVector(a.X * b.X,
                                                                                              a.Y * b.Y,
                                                                                              a.Z * b.Z);



        /// <summary>
        /// Vector substraction
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>New vector, the result of subtraction of vectors A and B</returns>
        public static SpaceVector operator -(SpaceVector a, SpaceVector b) => new SpaceVector(a.X - b.X,
                                                                                              a.Y - b.Y,
                                                                                              a.Z - b.Z);


        /// <summary>
        /// Vector division.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>New vector, the result of division of vectors A and B</returns>
        public static SpaceVector operator /(SpaceVector a, SpaceVector b)
        {
            double x;
            double y;
            double z;
            if (b.X != 0 && b.Y != 0 && b.Z != 0)
            {
                x = a.X / b.X;
                y = a.Y / b.Y;
                z = a.Z / b.Z;
            }
            else
            {
                throw new Exception();
            }

            return new SpaceVector(x, y, z);
        }

        /// <summary>
        /// Multiplying a vector by a number
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>New vector, the result of multiplying vector a by number b</returns>
        public static SpaceVector operator *(SpaceVector a, double b) => new SpaceVector(a.X * b, a.Y * b, a.Z * b);


        /// <summary>
        /// Dividing a vector by a number
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>New vector, the result of dividing vector a by number b</returns>
        public static SpaceVector operator /(SpaceVector a, double b)
        {
            double x;
            double y;
            double z;

            if (b != 0)
            {
                x = a.X / b;
                y = a.Y / b;
                z = a.Z / b;
            }
            else
            {
                throw new Exception();
            }

            return new SpaceVector(x, y, z);
        }


        /// <summary>
        /// Comparisons of two objects
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>If equal / unequal <=> true / false</returns>
        public override bool Equals(object obj)
        {
            if (obj is SpaceVector)
            {
                SpaceVector spaceVector = obj as SpaceVector;

                if ((X == spaceVector.X) && (Y == spaceVector.Y) && (Z == spaceVector.Z))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Returns HashCode of the object
        /// </summary>
        /// <returns>hashcode</returns>
        public override int GetHashCode() => X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
        
    }
}
