using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MyMath
{
    /// <summary>
    /// Vector operations on this struct are inmutable (except for normalize), that is if we sum
    /// vector a + vector b, then both, vector a and vector b still continue to have
    /// the same x, y values. Just a new vector instance is returned.
    ///
    /// Note however that you still can change an instance vector x, y values by directly changing its values.
    /// </summary>
    [System.Serializable]
    public struct Vector2D
    {
        public float x;
        public float y;

        public Vector2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2D(Vector2D vector)
        {
            this.x = vector.x;
            this.y = vector.y;
        }

        // TODO: Sum, Sub, MultByScalar, Length, Normalize, Dot  
        // TODO: Override some operators.

        #region Sum
        public Vector2D Sum(Vector2D vector)
        {
            // This operations doesn't mutate the original instance.
            return new Vector2D(x + vector.x, y + vector.y);
        }

        public static Vector2D Sum(Vector2D vectorA, Vector2D vectorB)
        {
            return vectorA.Sum(vectorB);
        }

        public static Vector2D operator +(Vector2D vectorA, Vector2D vectorB)
        {
            return Sum(vectorA, vectorB);
        }
        #endregion Sum

        #region Diff
        public Vector2D Diff(Vector2D vector)
        {
            return new Vector2D(x - vector.x, y - vector.y);
        }

        public static Vector2D Diff(Vector2D vectorA, Vector2D vectorB)
        {
            return vectorA.Diff(vectorB);
        }

        public static Vector2D operator -(Vector2D vectorA, Vector2D vectorB)
        {
            return Diff(vectorA, vectorB);
        }
        #endregion Diff

        #region Scale
        public Vector2D Scale(float scale)
        {
            return new Vector2D(x * scale, y * scale);
        }

        public static Vector2D Scale(Vector2D vectorA, float scale)
        {
            return vectorA.Scale(scale);
        }

        public static Vector2D operator *(Vector2D vectorA, float scale)
        {
            return Scale(vectorA, scale);
        }
        #endregion Scale

        #region Length
        public float Length()
        {
            return Mathf.Sqrt(x * x + y * y);
        }

        public static float Length(Vector2D vectorA)
        {
            return vectorA.Length();
        }
        #endregion Length

        #region Normalize
        /// <summary>
        /// This operation mutates the vector instance.
        /// </summary>
        public void Normalize()
        {
            float length = Length();
            x = x / length;
            y = y / length;
        }

        /// <summary>
        /// This returns a new vector instace but normalized.
        /// </summary>
        /// <returns>A normalized vector generated from curent vector.</returns>
        public Vector2D Normalized()
        {
            float length = Length();
            return new Vector2D(x / length, y / length);
        }
        #endregion Normalize

        #region Dot
        public float Dot(Vector2D vector)
        {
            return x * vector.x + y * vector.y;
        }

        public static float Dot(Vector2D vectorA, Vector2D vectorB)
        {
            return vectorA.Dot(vectorB);
        }

        public static float operator *(Vector2D vectorA, Vector2D vectorB)
        {
            return Dot(vectorA, vectorB);
        }
        #endregion Dot

        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }
}
