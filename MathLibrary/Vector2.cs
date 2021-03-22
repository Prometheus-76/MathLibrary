using System;

namespace MathClasses
{
    #region Vectors

    public struct Vector2
    {
        public float x;
        public float y;

        #region Constructors

        public Vector2(float x = 0f, float y = 0f)
        {
            this.x = x;
            this.y = y;
        }

        #endregion

        #region Addition

        //Overloads the addition operator
        public static Vector2 operator +(Vector2 lhs, Vector2 rhs)
        {
            Vector2 result;

            result.x = lhs.x + rhs.x;
            result.y = lhs.y + rhs.y;

            return result;
        }

        #endregion

        #region Subtraction

        //Overloads the subtraction operator
        public static Vector2 operator -(Vector2 lhs, Vector2 rhs)
        {
            Vector2 result;

            result.x = lhs.x - rhs.x;
            result.y = lhs.y - rhs.y;

            return result;
        }

        #endregion

        #region Multiplication

        //Overloads the multiplication operator, if the right operand is a float
        public static Vector2 operator *(Vector2 lhs, float rhs)
        {
            Vector2 result;

            result.x = lhs.x * rhs;
            result.y = lhs.y * rhs;

            return result;
        }

        //Overloads the multiplication operator, if the left operand is a float
        public static Vector2 operator *(float lhs, Vector2 rhs)
        {
            Vector2 result;

            result.x = lhs * rhs.x;
            result.y = lhs * rhs.y;

            return result;
        }

        //Overloads the multiplication operator, if the left operand is a float
        public static Vector2 operator *(Vector2 lhs, Vector2 rhs)
        {
            Vector2 result;

            result.x = lhs.x * rhs.x;
            result.y = lhs.y * rhs.y;

            return result;
        }

        #endregion

        #region Division

        //Overloads the multiplication operator, if the right operand is a float
        public static Vector2 operator /(Vector2 lhs, float rhs)
        {
            Vector2 result;

            result.x = lhs.x / rhs;
            result.y = lhs.y / rhs;

            return result;
        }

        //Overloads the multiplication operator, if the left operand is a float
        public static Vector2 operator /(float lhs, Vector2 rhs)
        {
            Vector2 result;

            result.x = lhs / rhs.x;
            result.y = lhs / rhs.y;

            return result;
        }

        //Overloads the multiplication operator, if the left operand is a float
        public static Vector2 operator /(Vector2 lhs, Vector2 rhs)
        {
            Vector2 result;

            result.x = lhs.x / rhs.x;
            result.y = lhs.y / rhs.y;

            return result;
        }

        #endregion

        #region Properties

        //Static
        static public Vector2 up { get; } = new Vector2(1, 0);
        static public Vector2 down { get; } = new Vector2(-1, 0);
        static public Vector2 left { get; } = new Vector2(0, -1);
        static public Vector2 right { get; } = new Vector2(1, 1);
        static public Vector2 one { get; } = new Vector2(1, 1);
        static public Vector2 zero { get; } = new Vector2(0, 0);
        static public Vector2 positiveInfinity { get; } = new Vector2(1f / 0f, 1f / 0f);
        static public Vector2 negativeInfinity { get; } = new Vector2(-1f / 0f, -1f / 0f);

        //Dynamic
        public double magnitude
        {
            get
            {
                //Pythagorean theorum
                return Math.Sqrt(Math.Abs(x * x) + Math.Abs(y * y));
            }
        }

        public Vector2 normalized
        {
            get
            {
                if (sqrMagnitude == 0)
                {
                    //Returns 0 if the vector magnitude is 0
                    return Vector2.zero;
                }
                else
                {
                    //Returns the normalized form of the vector
                    return new Vector2(x / (float)magnitude, y / (float)magnitude);
                }
            }
        }

        public double sqrMagnitude
        {
            get
            {
                //Magnitude but less expensive, used for comparing sizes of vectors without incurring a performance hit from the Math.Sqrt() function
                return Math.Abs(x * x) + Math.Abs(y * y);
            }
        }

        #endregion

        #region Functions

        //Returns the magnitude as a function
        public float Magnitude()
        {
            return (float)magnitude;
        }

        //Normalizes the Vector
        public void Normalize()
        {
            this = normalized;
        }

        //Returns the normalized form of the vector without normalizing it permanently
        public Vector2 Normalized()
        {
            return normalized;
        }

        //Returns the dot product of the current vector, given another
        public float Dot(Vector2 rhs)
        {
            return (x * rhs.x) + (y * rhs.y);
        }

        #endregion

        #region Function Overrides

        //Used for converting the vector to string form for clear representation
        public override string ToString()
        {
            return "(" + x + "," + y + ")";
        }

        #endregion
    }

    #endregion
}