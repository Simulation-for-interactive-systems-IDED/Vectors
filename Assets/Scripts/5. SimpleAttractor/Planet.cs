using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyMath;

public class Planet : MonoBehaviour
{
    [SerializeField]
    private Transform blackHole;

    [Header("Vectors")]
    [SerializeField]
    private Vector2D position;
    private Color positionColor = new Color(1, 1, 0);

    [SerializeField]
    private Vector2D velocity = new Vector2D(0, 0);
    private Color velocityColor = new Color(1, 0, 1);

    [SerializeField]
    private float accelerationMagnitude = 5f;
    private Vector2D acceleration = new Vector2D(0, 0);
    private Color accelerationColor = new Color(1, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Compute the direction from the current position to the blackHole.
        Vector2D direction = (Vector2D)blackHole.position - position;
        direction.Normalize();
        acceleration = direction.Scale(accelerationMagnitude);

        velocity = velocity + acceleration * Time.deltaTime;
        velocity.Limit(10f);

        position = position + velocity * Time.deltaTime;

        transform.position = position;

        // Just draw all the vectors for learning purposes.
        position.Draw(positionColor);
        velocity.Draw(position, velocityColor);
        acceleration.Draw(position, accelerationColor);
    }
}
