using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyMath
{
    public static class InteropVector2D
    {
        public static Vector2 ToVector2(Vector2D vector)
        {
            return new Vector2(vector.x, vector.y);
        }

        public static Vector3 ToVector3(Vector2D vector)
        {
            return new Vector3(vector.x, vector.y, 0);
        }

        public static Vector2D FromVector2(Vector2 vector)
        {
            return new Vector2D(vector.x, vector.y);
        }

        public static Vector2D FromVector3(Vector3 vector)
        {
            return new Vector2D(vector.x, vector.y);
        }
    }
}