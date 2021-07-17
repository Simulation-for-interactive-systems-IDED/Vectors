using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyMath;

public class BouncingBall : MonoBehaviour
{

    [SerializeField]
    private Vector2D position;
    private Color positionColor = new Color(1, 1, 0);

    [SerializeField]
    private Vector2D velocity = new Vector2D(2.5f, 5f);
    private Color velocityColor = new Color(1, 0, 1);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        position = position + velocity * Time.deltaTime;

        if ((position.x > 5) || (position.x < -5))
        {
            velocity.x = velocity.x * -1;
        }
        if ((position.y > 5) || (position.y < -5))
        {
            velocity.y = velocity.y * -1;
        }

        transform.position = position;
        position.Draw(positionColor);
        velocity.Draw(position, velocityColor);
    }
}
