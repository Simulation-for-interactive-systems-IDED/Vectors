using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyMath;

public class BouncingBallWithAccel : MonoBehaviour
{

    [SerializeField]
    private Vector2D position;
    private Color positionColor = new Color(1, 1, 0);

    [SerializeField]
    private Vector2D velocity = new Vector2D(0, 0);
    private Color velocityColor = new Color(1, 0, 1);

    [SerializeField]
    private Vector2D acceleration = new Vector2D(-0.001f, -0.01f);
    private Color accelerationColor = new Color(1, 0, 0);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        velocity = velocity + acceleration * Time.deltaTime;
        velocity.Limit(10f);

        position = position + velocity * Time.deltaTime;

        if ((position.x > 5) || (position.x < -5))
        {
            position.x = 4.9f * Mathf.Sign(velocity.x);
            velocity.x = velocity.x * -1;
        }
        if ((position.y > 5) || (position.y < -5))
        {
            position.y = 4.9f * Mathf.Sign(velocity.y);
            velocity.y = velocity.y * -1;
        }

        transform.position = position;

        // Just draw all the vectors for learning purposes.
        position.Draw(positionColor);
        velocity.Draw(position, velocityColor);
        acceleration.Draw(position, accelerationColor);
    }
}
