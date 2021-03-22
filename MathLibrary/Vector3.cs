using System;

namespace MathClasses
{
    #region Vectors

    public struct Vector3
    {
        public float x;
        public float y;
        public float z;

        #region Constructors

        public Vector3(float x = 0f, float y = 0f, float z = 0f)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        #endregion

        #region Addition

        //Overloads the addition operator
        public static Vector3 operator +(Vector3 lhs, Vector3 rhs)
        {
            Vector3 result;

            result.x = lhs.x + rhs.x;
            result.y = lhs.y + rhs.y;
            result.z = lhs.z + rhs.z;

            return result;
        }

        #endregion

        #region Subtraction

        //Overloads the subtraction operator
        public static Vector3 operator -(Vector3 lhs, Vector3 rhs)
        {
            Vector3 result;

            result.x = lhs.x - rhs.x;
            result.y = lhs.y - rhs.y;
            result.z = lhs.z - rhs.z;

            return result;
        }

        #endregion

        #region Multiplication

        //Overloads the multiplication operator, if the right operand is a float
        public static Vector3 operator *(Vector3 lhs, float rhs)
        {
            Vector3 result;

            result.x = lhs.x * rhs;
            result.y = lhs.y * rhs;
            result.z = lhs.z * rhs;

            return result;
        }

        //Overloads the multiplication operator, if the left operand is a float
        public static Vector3 operator *(float lhs, Vector3 rhs)
        {
            Vector3 result;

            result.x = lhs * rhs.x;
            result.y = lhs * rhs.y;
            result.z = lhs * rhs.z;

            return result;
        }

        //Overloads the multiplication operator, if the left operand is a float
        public static Vector3 operator *(Vector3 lhs, Vector3 rhs)
        {
            Vector3 result;

            result.x = lhs.x * rhs.x;
            result.y = lhs.y * rhs.y;
            result.z = lhs.z * rhs.z;

            return result;
        }

        #endregion

        #region Division

        //Overloads the multiplication operator, if the right operand is a float
        public static Vector3 operator /(Vector3 lhs, float rhs)
        {
            Vector3 result;

            result.x = lhs.x / rhs;
            result.y = lhs.y / rhs;
            result.z = lhs.z / rhs;

            return result;
        }

        //Overloads the multiplication operator, if the left operand is a float
        public static Vector3 operator /(float lhs, Vector3 rhs)
        {
            Vector3 result;

            result.x = lhs / rhs.x;
            result.y = lhs / rhs.y;
            result.z = lhs / rhs.z;

            return result;
        }

        //Overloads the multiplication operator, if the left operand is a float
        public static Vector3 operator /(Vector3 lhs, Vector3 rhs)
        {
            Vector3 result;

            result.x = lhs.x / rhs.x;
            result.y = lhs.y / rhs.y;
            result.z = lhs.z / rhs.z;

            return result;
        }

        #endregion

        #region Properties

        //Static
        static public Vector3 up { get; } = new Vector3(0, 1, 0);
        static public Vector3 down { get; } = new Vector3(0, -1, 0);
        static public Vector3 left { get; } = new Vector3(-1, 0, 0);
        static public Vector3 right { get; } = new Vector3(1, 0, 0);
        static public Vector3 forward { get; } = new Vector3(0, 0, 1);
        static public Vector3 back { get; } = new Vector3(0, 0, -1);
        static public Vector3 one { get; } = new Vector3(1, 1, 1);
        static public Vector3 zero { get; } = new Vector3(0, 0, 0);
        static public Vector3 positiveInfinity { get; } = new Vector3(1f / 0f, 1f / 0f, 1f / 0f);
        static public Vector3 negativeInfinity { get; } = new Vector3(-1f / 0f, -1f / 0f, -1f / 0f);

        //Dynamic
        public double magnitude
        {
            get
            {
                //Pythagorean theorum
                return Math.Sqrt(Math.Abs(x * x) + Math.Abs(y * y) + Math.Abs(z * z));
            }
        }

        public Vector3 normalized
        {
            get
            {
                if (sqrMagnitude == 0)
                {
                    //Returns 0 if the vector magnitude is 0
                    return Vector3.zero;
                }
                else
                {
                    //Returns the normalized form of the vector
                    return new Vector3(x / (float)magnitude, y / (float)magnitude, z / (float)magnitude);
                }
            }
        }

        public double sqrMagnitude
        {
            get
            {
                //Magnitude but less expensive, used for comparing sizes of vectors without incurring a performance hit from the Math.Sqrt() function
                return Math.Abs(x * x) + Math.Abs(y * y) + Math.Abs(z * z);
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
        public Vector3 Normalized()
        {
            return normalized;
        }

        //Returns the dot product of the current vector, given another
        public float Dot(Vector3 rhs)
        {
            return (x * rhs.x) + (y * rhs.y) + (z * rhs.z);
        }

        //Returns the cross product of the current vector, given another
        public Vector3 Cross(Vector3 rhs)
        {
            Vector3 result;

            result.x = (y * rhs.z) - (z * rhs.y);
            result.y = (z * rhs.x) - (x * rhs.z);
            result.z = (x * rhs.y) - (y * rhs.x);

            return result;
        }

        #endregion

        #region Function Overrides

        //Used for converting the vector to string form for clear representation
        public override string ToString()
        {
            return "(" + x + "," + y + "," + z + ")";
        }

        #endregion
    }

    #endregion
}