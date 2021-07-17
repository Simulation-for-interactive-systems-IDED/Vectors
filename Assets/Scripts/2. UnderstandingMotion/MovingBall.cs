using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyMath;

public class MovingBall : MonoBehaviour
{
    [SerializeField]
    private Vector2D position;
    private Color positionColor = new Color(1, 1, 0);

    [SerializeField]
    private Vector2D velocity = new Vector2D(1, 0);
    private Color velocityColor = new Color(1, 0, 1);

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
    }

    void Update()
    {
        // Just draw all the vectors for learning purposes.
        position.Draw(positionColor);
        velocity.Draw(position, velocityColor);
    }

    public void ManualUpdate()
    {
        position = position + velocity;
        transform.position = position;
    }
}
