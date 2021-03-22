using System;

namespace MathClasses
{
    #region Matrices

    public struct Matrix4
    {
        public float m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14, m15, m16;

        #region Constructors

        public Matrix4(float m1 = 1f, float m2 = 0f, float m3 = 0f, float m4 = 0f, float m5 = 0f, float m6 = 1f, float m7 = 0f, float m8 = 0f, float m9 = 0f, float m10 = 0f, float m11 = 1f, float m12 = 0f, float m13 = 0f, float m14 = 0f, float m15 = 0f, float m16 = 1f)
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
            this.m10 = m10;
            this.m11 = m11;
            this.m12 = m12;
            this.m13 = m13;
            this.m14 = m14;
            this.m15 = m15;
            this.m16 = m16;
        }

        #endregion

        #region Addition

        public static Matrix4 operator +(Matrix4 lhs, Matrix4 rhs)
        {
            Matrix4 result = new Matrix4();

            result.m1 = lhs.m1 + rhs.m1;
            result.m2 = lhs.m2 + rhs.m2;
            result.m3 = lhs.m3 + rhs.m3;
            result.m4 = lhs.m4 + rhs.m4;
            result.m5 = lhs.m5 + rhs.m5;
            result.m6 = lhs.m6 + rhs.m6;
            result.m7 = lhs.m7 + rhs.m7;
            result.m8 = lhs.m8 + rhs.m8;
            result.m9 = lhs.m9 + rhs.m9;
            result.m10 = lhs.m10 + rhs.m10;
            result.m11 = lhs.m11 + rhs.m11;
            result.m12 = lhs.m12 + rhs.m12;
            result.m13 = lhs.m13 + rhs.m13;
            result.m14 = lhs.m14 + rhs.m14;
            result.m15 = lhs.m15 + rhs.m15;
            result.m16 = lhs.m16 + rhs.m16;

            return result;
        }

        #endregion

        #region Subtraction

        public static Matrix4 operator -(Matrix4 lhs, Matrix4 rhs)
        {
            Matrix4 result = new Matrix4();

            result.m1 = lhs.m1 - rhs.m1;
            result.m2 = lhs.m2 - rhs.m2;
            result.m3 = lhs.m3 - rhs.m3;
            result.m4 = lhs.m4 - rhs.m4;
            result.m5 = lhs.m5 - rhs.m5;
            result.m6 = lhs.m6 - rhs.m6;
            result.m7 = lhs.m7 - rhs.m7;
            result.m8 = lhs.m8 - rhs.m8;
            result.m9 = lhs.m9 - rhs.m9;
            result.m10 = lhs.m10 - rhs.m10;
            result.m11 = lhs.m11 - rhs.m11;
            result.m12 = lhs.m12 - rhs.m12;
            result.m13 = lhs.m13 - rhs.m13;
            result.m14 = lhs.m14 - rhs.m14;
            result.m15 = lhs.m15 - rhs.m15;
            result.m16 = lhs.m16 - rhs.m16;

            return result;
        }

        #endregion

        #region Multiplication

        public static Matrix4 operator *(Matrix4 lhs, Matrix4 rhs)
        {
            Matrix4 result = new Matrix4(0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0);

            //First column
            result.m1 = (lhs.m1 * rhs.m1) + (lhs.m5 * rhs.m2) + (lhs.m9 * rhs.m3) + (lhs.m13 * rhs.m4);
            result.m2 = (lhs.m2 * rhs.m1) + (lhs.m6 * rhs.m2) + (lhs.m10 * rhs.m3) + (lhs.m14 * rhs.m4);
            result.m3 = (lhs.m3 * rhs.m1) + (lhs.m7 * rhs.m2) + (lhs.m11 * rhs.m3) + (lhs.m15 * rhs.m4);
            result.m4 = (lhs.m4 * rhs.m1) + (lhs.m8 * rhs.m2) + (lhs.m12 * rhs.m3) + (lhs.m16 * rhs.m4);

            //Second column
            result.m5 = (lhs.m1 * rhs.m5) + (lhs.m5 * rhs.m6) + (lhs.m9 * rhs.m7) + (lhs.m13 * rhs.m8);
            result.m6 = (lhs.m2 * rhs.m5) + (lhs.m6 * rhs.m6) + (lhs.m10 * rhs.m7) + (lhs.m14 * rhs.m8);
            result.m7 = (lhs.m3 * rhs.m5) + (lhs.m7 * rhs.m6) + (lhs.m11 * rhs.m7) + (lhs.m15 * rhs.m8);
            result.m8 = (lhs.m4 * rhs.m5) + (lhs.m8 * rhs.m6) + (lhs.m12 * rhs.m7) + (lhs.m16 * rhs.m8);

            //Third column
            result.m9 = (lhs.m1 * rhs.m9) + (lhs.m5 * rhs.m10) + (lhs.m9 * rhs.m11) + (lhs.m13 * rhs.m12);
            result.m10 = (lhs.m2 * rhs.m9) + (lhs.m6 * rhs.m10) + (lhs.m10 * rhs.m11) + (lhs.m14 * rhs.m12);
            result.m11 = (lhs.m3 * rhs.m9) + (lhs.m7 * rhs.m10) + (lhs.m11 * rhs.m11) + (lhs.m15 * rhs.m12);
            result.m12 = (lhs.m4 * rhs.m9) + (lhs.m8 * rhs.m10) + (lhs.m12 * rhs.m11) + (lhs.m16 * rhs.m12);

            //Fourth column
            result.m13 = (lhs.m1 * rhs.m13) + (lhs.m5 * rhs.m14) + (lhs.m9 * rhs.m15) + (lhs.m13 * rhs.m16);
            result.m14 = (lhs.m2 * rhs.m13) + (lhs.m6 * rhs.m14) + (lhs.m10 * rhs.m15) + (lhs.m14 * rhs.m16);
            result.m15 = (lhs.m3 * rhs.m13) + (lhs.m7 * rhs.m14) + (lhs.m11 * rhs.m15) + (lhs.m15 * rhs.m16);
            result.m16 = (lhs.m4 * rhs.m13) + (lhs.m8 * rhs.m14) + (lhs.m12 * rhs.m15) + (lhs.m16 * rhs.m16);

            return result;
        }

        public static Vector4 operator *(Matrix4 lhs, Vector4 rhs)
        {
            Vector4 result = new Vector4();

            //Apply transformations to vector
            result.x = (lhs.m1 * rhs.x) + (lhs.m5 * rhs.y) + (lhs.m9 * rhs.z) + (lhs.m13 * rhs.w);
            result.y = (lhs.m2 * rhs.x) + (lhs.m6 * rhs.y) + (lhs.m10 * rhs.z) + (lhs.m14 * rhs.w);
            result.z = (lhs.m3 * rhs.x) + (lhs.m7 * rhs.y) + (lhs.m11 * rhs.z) + (lhs.m15 * rhs.w);
            result.w = (lhs.m4 * rhs.x) + (lhs.m8 * rhs.y) + (lhs.m12 * rhs.z) + (lhs.m16 * rhs.w);

            return result;
        }

        #endregion

        #region Functions

        #region Set Rotation

        //Set functions
        public void SetRotateX(float angleRadians)
        {
            m1 = 1f;
            m6 = (float)Math.Cos(angleRadians);
            m7 = (float)Math.Sin(angleRadians);
            m10 = (float)-Math.Sin(angleRadians);
            m11 = (float)Math.Cos(angleRadians);
            m16 = 1f;
        }

        public void SetRotateY(float angleRadians)
        {
            m1 = (float)Math.Cos(angleRadians);
            m3 = (float)-Math.Sin(angleRadians);
            m6 = 1f;
            m9 = (float)Math.Sin(angleRadians);
            m11 = (float)Math.Cos(angleRadians);
            m16 = 1f;
        }

        public void SetRotateZ(float angleRadians)
        {
            m1 = (float)Math.Cos(angleRadians);
            m2 = (float)Math.Sin(angleRadians);
            m5 = (float)-Math.Sin(angleRadians);
            m6 = (float)Math.Cos(angleRadians);
            m11 = 1f;
            m16 = 1f;
        }

        #endregion

        #region Add Rotations

        //Add functions
        public void AddRotateX(float angleRadians)
        {
            Matrix4 transformationMatrix = new Matrix4();

            transformationMatrix.m1 = 1f;
            transformationMatrix.m5 = (float)Math.Cos(angleRadians);
            transformationMatrix.m6 = (float)-Math.Sin(angleRadians);
            transformationMatrix.m8 = (float)Math.Sin(angleRadians);
            transformationMatrix.m9 = (float)Math.Cos(angleRadians);

            this *= transformationMatrix;
        }

        public void AddRotateY(float angleRadians)
        {
            Matrix4 transformationMatrix = new Matrix4();

            transformationMatrix.m1 = (float)Math.Cos(angleRadians);
            transformationMatrix.m3 = (float)Math.Sin(angleRadians);
            transformationMatrix.m5 = 1f;
            transformationMatrix.m7 = (float)-Math.Sin(angleRadians);
            transformationMatrix.m9 = (float)Math.Cos(angleRadians);

            this *= transformationMatrix;
        }

        public void AddRotateZ(float angleRadians)
        {
            Matrix4 transformationMatrix = new Matrix4();

            transformationMatrix.m1 = (float)Math.Cos(angleRadians);
            transformationMatrix.m2 = (float)-Math.Sin(angleRadians);
            transformationMatrix.m4 = (float)Math.Sin(angleRadians);
            transformationMatrix.m5 = (float)Math.Cos(angleRadians);
            transformationMatrix.m9 = 1f;

            this *= transformationMatrix;
        }

        #endregion

        public void SetValue(Matrix4 newMatrix)
        {
            m1 = newMatrix.m1;
            m2 = newMatrix.m2;
            m3 = newMatrix.m3;
            m4 = newMatrix.m4;
            m5 = newMatrix.m5;
            m6 = newMatrix.m6;
            m7 = newMatrix.m7;
            m8 = newMatrix.m8;
            m9 = newMatrix.m9;
            m10 = newMatrix.m10;
            m11 = newMatrix.m11;
            m12 = newMatrix.m12;
            m13 = newMatrix.m13;
            m14 = newMatrix.m14;
            m15 = newMatrix.m15;
            m16 = newMatrix.m16;
        }

        #endregion
    }

    #endregion
}