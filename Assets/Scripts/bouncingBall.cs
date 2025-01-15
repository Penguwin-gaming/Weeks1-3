using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouncingBall : MonoBehaviour
{

    public float xSpeed = 0.025f;
    public float ySpeed = 0.025f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 pos = transform.position;
        pos.x += xSpeed;
        pos.y += ySpeed;

        Vector2 squareInScreenSpace = Camera.main.WorldToScreenPoint(pos);

        if (squareInScreenSpace.x < 0 || squareInScreenSpace.x > Screen.width)
        {
            xSpeed = xSpeed * -1;
        }

        transform.position = pos;

        if (squareInScreenSpace.y < 0 || squareInScreenSpace.y > Screen.height)
        {
            ySpeed = ySpeed * -1;
        }

        transform.position = pos;
    }
}
