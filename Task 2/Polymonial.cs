using System;
using System.Linq;

namespace Polynomial
{
    /// <summary>
    /// Class for working with polynomial
    /// </summary>
    public class Polymonial
    {
        /// <summary>
        /// A field for storing the coefficients.
        /// </summary>
       
        private double[] сoefficients;

        /// <summary>
        /// A field for storing the degree.
        /// </summary>
        
        private int degree;

        public double this[int index]
        {
            get => сoefficients[index];
        }

        public Polymonial(params double[] data)
        {
            if (data.Length > 0)
            {
                degree = data.Length;
                сoefficients = data;
            }
            else
            {
                throw new Exception("The field cannot exist");
            }
        }


        /// <summary>
        /// Сonverting all elements to negative
        /// </summary>
        /// <param name="a"></param>
        /// <returns>opposite сoefficients</returns>
        public static Polymonial operator - (Polymonial a)
        {
            double[] newPolymonial = new double[a.degree];

            for (int i = 0; i < a.degree; i++)
            {
                newPolymonial[i] = -a[i];
            }

            return new Polymonial(newPolymonial);
        }

        /// <summary>
        /// Addition
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a + b</returns>
        public static Polymonial operator +(Polymonial a, Polymonial b)
        {
            double[] newPolymonial;

            if(a.degree > b.degree)
            {
                newPolymonial = new double[a.degree];

                for (int i = 0; i < a.degree; i++)
                {
                    if(i < b.degree)
                    {
                        newPolymonial[i] = a[i] + b[i];
                    }
                    else
                    {
                        newPolymonial[i] = a[i];
                    }
                }

                return new Polymonial(newPolymonial);
            }
            else if(a.degree < b.degree){
                newPolymonial = new double[b.degree];

                for (int i = 0; i < b.degree; i++)
                {
                    if (i < a.degree)
                    {
                        newPolymonial[i] = a[i] + b[i];
                    }
                    else
                    {
                        newPolymonial[i] = b[i];
                    }
                }

                return new Polymonial(newPolymonial);
            }
            else
            {
                newPolymonial = new double[b.degree];

                for (int i = 0; i < b.degree; i++)
                {
                    newPolymonial[i] = a[i] + b[i];
                }

                return new Polymonial(newPolymonial);
            }
        }

        /// <summary>
        /// Subtractio any poly with poly
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a - b</returns>
        public static Polymonial operator -(Polymonial a, Polymonial b)
        {
            double[] newPolymonial;

            if (a.degree > b.degree)
            {
                newPolymonial = new double[a.degree];

                for (int i = 0; i < a.degree; i++)
                {
                    if (i < b.degree)
                    {
                        newPolymonial[i] = a[i] - b[i];
                    }
                    else
                    {
                        newPolymonial[i] = a[i];
                    }
                }

                return new Polymonial(newPolymonial);
            }
            else if (a.degree < b.degree)
            {
                newPolymonial = new double[b.degree];

                for (int i = 0; i < b.degree; i++)
                {
                    if (i < a.degree)
                    {
                        newPolymonial[i] = a[i] - b[i];
                    }
                    else
                    {
                        newPolymonial[i] = b[i];
                    }
                }

                return new Polymonial(newPolymonial);
            }
            else
            {
                newPolymonial = new double[b.degree];

                for (int i = 0; i < b.degree; i++)
                {
                    newPolymonial[i] = a[i] - b[i];
                }

                return new Polymonial(newPolymonial);
            }
        }

        /// <summary>
        /// multiplication
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a * b</returns>
        public static Polymonial operator *(Polymonial a, Polymonial b)
        {
            double[] newPolymonial = new double[a.degree + b.degree - 1];

            for (int i = 0; i < a.degree; i++)
            {
                for(int j = 0; j < b.degree; j++)
                {
                    newPolymonial[i + j] += a[i] * b[j];

                }
            }

            return new Polymonial(newPolymonial);
        }

        /// <summary>
        /// addition
        /// </summary>
        /// <param name="b"></param>
        /// <param name="a"></param>
        /// <returns>Polymonial(a) + b</returns>
        public static Polymonial operator +(Polymonial a, double b)
        {
            double[] newPolymonial = a.сoefficients;

            newPolymonial[0] += b;

            return new Polymonial(newPolymonial);
        }

        /// <summary>
        /// Addition
        /// </summary>
        /// <param name="b"></param>
        /// <param name="a"></param>
        /// <returns>Polymonial(a) + b</returns>
        public static Polymonial operator +(double b, Polymonial a) =>  a + b;


        /// <summary>
        /// Substraction
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns> Polymonial(a) - b</returns>
        public static Polymonial operator -(Polymonial a, double b)
        {
            double[] newPolymonial = a.сoefficients;

            newPolymonial[0] -= b;

            return new Polymonial(newPolymonial);
        }

        /// <summary>
        /// Substarction
        /// </summary>
        /// <param name="b"></param>
        /// <param name="a"></param>
        /// <returns>Polymonial(a) + b</returns>
        public static Polymonial operator -(double b, Polymonial a) => a - b;
        

        /// <summary>
        /// Multiplication
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Poly(a) * b</returns>
        public static Polymonial operator *(Polymonial a, double b)
        {
            double[] newPolymonial = a.сoefficients;

            for (int i = 0; i < a.degree; i++)
            {
                newPolymonial[i] = a[i] * b;

            }

            return new Polymonial(newPolymonial);
        }

        /// <summary>
        /// Multiplication
        /// </summary>
        /// <param name="b"></param>
        /// <param name="a"></param>
        /// <returns>a * b</returns>
        public static Polymonial operator *(double b, Polymonial a) =>a * b;

        /// <summary>
        /// Division
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Polymonial(a) / b </returns>
        public static Polymonial operator /(Polymonial a, double b)
        {
            double[] newPolymonial = a.сoefficients;

            if(b != 0)
            {
                for (int i = 0; i < a.degree; i++)
                {
                    newPolymonial[i] = a[i] / b;

                }
            }
            else
            {
                throw new DivideByZeroException();
            }

            return new Polymonial(newPolymonial);
        }

        /// <summary>
        /// Сomparison
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>If equal / unequal <=> true / false</returns>
        public override bool Equals(object obj)
        {
            if (obj is Polymonial)
            {
                Polymonial polymonial = obj as Polymonial;

                if (Enumerable.SequenceEqual(this.сoefficients, polymonial.сoefficients))
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
        public override int GetHashCode() => сoefficients.GetHashCode() ^ degree.GetHashCode();
        
    }
}
