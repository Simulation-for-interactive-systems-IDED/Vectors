using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyMath;

public class UsingVector : MonoBehaviour
{
    [Header("Origin")]
    [SerializeField]
    private Vector2D origin = new Vector2D(0, 0);

    [Header("Vector")]
    [SerializeField]
    private Color color = Color.green;

    [SerializeField]
    private Vector2D vector = new Vector2D(10, 10);

    // Update is called once per frame
    void Update()
    {
        // Note that we are calling a extension method.
        // It's equivalent to do the next:
        // DrawVector2D.DoDraw(origin, vector, color);
        // The extension methods are just syntax sugar for static methods.
        vector.Draw(origin, color);
    }
}
