using System;

namespace MathClasses
{
    #region Vectors

    public struct Vector4
    {
        public float x;
        public float y;
        public float z;
        public float w;

        #region Constructors

        public Vector4(float x = 0f, float y = 0f, float z = 0f, float w = 0f)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        #endregion

        #region Addition

        //Overloads the addition operator
        public static Vector4 operator +(Vector4 lhs, Vector4 rhs)
        {
            Vector4 result;

            result.x = lhs.x + rhs.x;
            result.y = lhs.y + rhs.y;
            result.z = lhs.z + rhs.z;
            result.w = lhs.w + rhs.w;

            return result;
        }

        #endregion

        #region Subtraction

        //Overloads the subtraction operator
        public static Vector4 operator -(Vector4 lhs, Vector4 rhs)
        {
            Vector4 result;

            result.x = lhs.x - rhs.x;
            result.y = lhs.y - rhs.y;
            result.z = lhs.z - rhs.z;
            result.w = lhs.w - rhs.w;

            return result;
        }

        #endregion

        #region Multiplication

        //Overloads the multiplication operator, if the right operand is a float
        public static Vector4 operator *(Vector4 lhs, float rhs)
        {
            Vector4 result;

            result.x = lhs.x * rhs;
            result.y = lhs.y * rhs;
            result.z = lhs.z * rhs;
            result.w = lhs.w * rhs;

            return result;
        }

        //Overloads the multiplication operator, if the left operand is a float
        public static Vector4 operator *(float lhs, Vector4 rhs)
        {
            Vector4 result;

            result.x = lhs * rhs.x;
            result.y = lhs * rhs.y;
            result.z = lhs * rhs.z;
            result.w = lhs * rhs.w;

            return result;
        }

        //Overloads the multiplication operator, if the left operand is a float
        public static Vector4 operator *(Vector4 lhs, Vector4 rhs)
        {
            Vector4 result;

            result.x = lhs.x * rhs.x;
            result.y = lhs.y * rhs.y;
            result.z = lhs.z * rhs.z;
            result.w = lhs.w * rhs.w;

            return result;
        }

        #endregion

        #region Division

        //Overloads the multiplication operator, if the right operand is a float
        public static Vector4 operator /(Vector4 lhs, float rhs)
        {
            Vector4 result;

            result.x = lhs.x / rhs;
            result.y = lhs.y / rhs;
            result.z = lhs.z / rhs;
            result.w = lhs.w / rhs;

            return result;
        }

        //Overloads the multiplication operator, if the left operand is a float
        public static Vector4 operator /(float lhs, Vector4 rhs)
        {
            Vector4 result;

            result.x = lhs / rhs.x;
            result.y = lhs / rhs.y;
            result.z = lhs / rhs.z;
            result.w = lhs / rhs.w;

            return result;
        }

        //Overloads the multiplication operator, if the left operand is a float
        public static Vector4 operator /(Vector4 lhs, Vector4 rhs)
        {
            Vector4 result;

            result.x = lhs.x / rhs.x;
            result.y = lhs.y / rhs.y;
            result.z = lhs.z / rhs.z;
            result.w = lhs.w / rhs.w;

            return result;
        }

        #endregion

        #region Properties

        //Static
        static public Vector4 one { get; } = new Vector4(1, 1, 1, 1);
        static public Vector4 zero { get; } = new Vector4(0, 0, 0, 0);
        static public Vector4 positiveInfinity { get; } = new Vector4(1f / 0f, 1f / 0f, 1f / 0f, 1f / 0f);
        static public Vector4 negativeInfinity { get; } = new Vector4(-1f / 0f, -1f / 0f, -1f / 0f, -1f / 0f);

        //Dynamic
        public double magnitude
        {
            get
            {
                //Pythagorean theorum
                return Math.Sqrt(Math.Abs(x * x) + Math.Abs(y * y) + Math.Abs(z * z) + Math.Abs(w * w));
            }
        }

        public Vector4 normalized
        {
            get
            {
                if (sqrMagnitude == 0)
                {
                    //Returns 0 if the vector magnitude is 0
                    return Vector4.zero;
                }
                else
                {
                    //Returns the normalized form of the vector
                    return new Vector4(x / (float)magnitude, y / (float)magnitude, z / (float)magnitude, w / (float)magnitude);
                }
            }
        }

        public double sqrMagnitude
        {
            get
            {
                //Magnitude but less expensive, used for comparing sizes of vectors without incurring a performance hit from the Math.Sqrt() function
                return Math.Abs(x * x) + Math.Abs(y * y) + Math.Abs(z * z) + Math.Abs(w * w);
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
        public Vector4 Normalized()
        {
            return normalized;
        }

        //Returns the dot product of the current vector, given another
        public float Dot(Vector4 rhs)
        {
            return (x * rhs.x) + (y * rhs.y) + (z * rhs.z) + (w * rhs.w);
        }

        //Returns the cross product of the current vector, given another
        public Vector4 Cross(Vector4 rhs)
        {
            Vector4 result;

            result.x = (y * rhs.z) - (z * rhs.y);
            result.y = (z * rhs.x) - (x * rhs.z);
            result.z = (x * rhs.y) - (y * rhs.x);
            result.w = 0f;

            return result;
        }

        #endregion

        #region Function Overrides

        //Used for converting the vector to string form for clear representation
        public override string ToString()
        {
            return "(" + x + "," + y + "," + z + "," + w + ")";
        }

        #endregion
    }

    #endregion
}