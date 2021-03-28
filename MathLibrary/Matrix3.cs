using System;

namespace MathClasses
{
    #region Matrices

    public struct Matrix3
    {
        public float m1, m2, m3, m4, m5, m6, m7, m8, m9;

        #region Constructors

        public Matrix3(float m1 = 1f, float m2 = 0f, float m3 = 0f, float m4 = 0f, float m5 = 1f, float m6 = 0f, float m7 = 0f, float m8 = 0f, float m9 = 1f)
        {
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
            this.m4 = m4;
            this.m5 = m5;
            this.m6 = m6;
            this.m7 = m7;
            this.m8 = m8;
            this.m9 = m9;
        }

        #endregion

        #region Addition

        public static Matrix3 operator+(Matrix3 lhs, Matrix3 rhs)
        {
            Matrix3 result = new Matrix3();

            result.m1 = lhs.m1 + rhs.m1;
            result.m2 = lhs.m2 + rhs.m2;
            result.m3 = lhs.m3 + rhs.m3;
            result.m4 = lhs.m4 + rhs.m4;
            result.m5 = lhs.m5 + rhs.m5;
            result.m6 = lhs.m6 + rhs.m6;
            result.m7 = lhs.m7 + rhs.m7;
            result.m8 = lhs.m8 + rhs.m8;
            result.m9 = lhs.m9 + rhs.m9;

            return result;
        }

        #endregion

        #region Subtraction

        public static Matrix3 operator -(Matrix3 lhs, Matrix3 rhs)
        {
            Matrix3 result = new Matrix3();

            result.m1 = lhs.m1 - rhs.m1;
            result.m2 = lhs.m2 - rhs.m2;
            result.m3 = lhs.m3 - rhs.m3;
            result.m4 = lhs.m4 - rhs.m4;
            result.m5 = lhs.m5 - rhs.m5;
            result.m6 = lhs.m6 - rhs.m6;
            result.m7 = lhs.m7 - rhs.m7;
            result.m8 = lhs.m8 - rhs.m8;
            result.m9 = lhs.m9 - rhs.m9;

            return result;
        }

        #endregion

        #region Multiplication

        public static Matrix3 operator*(Matrix3 lhs, Matrix3 rhs)
        {
            Matrix3 result = new Matrix3(0,0,0,0,0,0,0,0,0);

            //First column
            result.m1 = (lhs.m1 * rhs.m1) + (lhs.m4 * rhs.m2) + (lhs.m7 * rhs.m3);
            result.m2 = (lhs.m2 * rhs.m1) + (lhs.m5 * rhs.m2) + (lhs.m8 * rhs.m3);
            result.m3 = (lhs.m3 * rhs.m1) + (lhs.m6 * rhs.m2) + (lhs.m9 * rhs.m3);

            //Second column
            result.m4 = (lhs.m1 * rhs.m4) + (lhs.m4 * rhs.m5) + (lhs.m7 * rhs.m6);
            result.m5 = (lhs.m2 * rhs.m4) + (lhs.m5 * rhs.m5) + (lhs.m8 * rhs.m6);
            result.m6 = (lhs.m3 * rhs.m4) + (lhs.m6 * rhs.m5) + (lhs.m9 * rhs.m6);

            //Third column
            result.m7 = (lhs.m1 * rhs.m7) + (lhs.m4 * rhs.m8) + (lhs.m7 * rhs.m9);
            result.m8 = (lhs.m2 * rhs.m7) + (lhs.m5 * rhs.m8) + (lhs.m8 * rhs.m9);
            result.m9 = (lhs.m3 * rhs.m7) + (lhs.m6 * rhs.m8) + (lhs.m9 * rhs.m9);

            return result;
        }

        public static Vector3 operator *(Matrix3 lhs, Vector3 rhs)
        {
            Vector3 result = new Vector3();

            //Apply transformations to vector
            result.x = (lhs.m1 * rhs.x) + (lhs.m4 * rhs.y) + (lhs.m7 * rhs.z);
            result.y = (lhs.m2 * rhs.x) + (lhs.m5 * rhs.y) + (lhs.m8 * rhs.z);
            result.z = (lhs.m3 * rhs.x) + (lhs.m6 * rhs.y) + (lhs.m9 * rhs.z);

            return result;
        }

        #endregion

        #region Functions

        #region Set Rotation

        //Set functions
        public void SetRotateX(float angleRadians)
        {
            m1 = 1f;
            m5 = (float)Math.Cos(angleRadians);
            m6 = (float)Math.Sin(angleRadians);
            m8 = (float)-Math.Sin(angleRadians);
            m9 = (float)Math.Cos(angleRadians);
        }

        public void SetRotateY(float angleRadians)
        {
            m1 = (float)Math.Cos(angleRadians);
            m3 = (float)-Math.Sin(angleRadians);
            m5 = 1f;
            m7 = (float)Math.Sin(angleRadians);
            m9 = (float)Math.Cos(angleRadians);
        }

        public void SetRotateZ(float angleRadians)
        {
            m1 = (float)Math.Cos(angleRadians);
            m2 = (float)Math.Sin(angleRadians);
            m4 = (float)-Math.Sin(angleRadians);
            m5 = (float)Math.Cos(angleRadians);
            m9 = 1f;
        }

        #endregion

        #region Add Rotations

        //Add functions
        public void AddRotateX(float angleRadians)
        {
            Matrix3 transformationMatrix = new Matrix3();

            transformationMatrix.m1 = 1f;
            transformationMatrix.m5 = (float)Math.Cos(angleRadians);
            transformationMatrix.m6 = (float)-Math.Sin(angleRadians);
            transformationMatrix.m8 = (float)Math.Sin(angleRadians);
            transformationMatrix.m9 = (float)Math.Cos(angleRadians);

            this = this * transformationMatrix;
        }

        public void AddRotateY(float angleRadians)
        {
            Matrix3 transformationMatrix = new Matrix3();

            transformationMatrix.m1 = (float)Math.Cos(angleRadians);
            transformationMatrix.m3 = (float)Math.Sin(angleRadians);
            transformationMatrix.m5 = 1f;
            transformationMatrix.m7 = (float)-Math.Sin(angleRadians);
            transformationMatrix.m9 = (float)Math.Cos(angleRadians);
            
            this = this * transformationMatrix;
        }

        public void AddRotateZ(float angleRadians)
        {
            Matrix3 transformationMatrix = new Matrix3();

            transformationMatrix.m1 = (float)Math.Cos(angleRadians);
            transformationMatrix.m2 = (float)-Math.Sin(angleRadians);
            transformationMatrix.m4 = (float)Math.Sin(angleRadians);
            transformationMatrix.m5 = (float)Math.Cos(angleRadians);
            transformationMatrix.m9 = 1f;
            
            this = this * transformationMatrix;
        }
        
        #endregion

        public void SetValue(Matrix3 newMatrix)
        {
            this.m1 = newMatrix.m1;
            this.m2 = newMatrix.m2;
            this.m3 = newMatrix.m3;
            this.m4 = newMatrix.m4;
            this.m5 = newMatrix.m5;
            this.m6 = newMatrix.m6;
            this.m7 = newMatrix.m7;
            this.m8 = newMatrix.m8;
            this.m9 = newMatrix.m9;
        }

        #endregion

        #region Function Overrides

        public override string ToString()
        {
            return "(" + m1 + "," + m2 + "," + m3 + "," + m4 + "," + m5 + "," + m6 + "," + m7 + "," + m8 + "," + m9 + ")";
        }

        #endregion
    }

    #endregion
}