using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class bouncingBall : MonoBehaviour
{

    public float xSpeed = 0.025f;
    public float ySpeed = 0.025f;
    public float sizeChange = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 scale = transform.localScale;

        if (Input.GetKey(KeyCode.DownArrow))
        {
            scale.x -= sizeChange;
            scale.y -= sizeChange;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            scale.x += sizeChange;
            scale.y += sizeChange;
        }

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

        if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += xSpeed;
            pos.y += ySpeed;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= xSpeed;
            pos.y -= ySpeed;
        }
    }
}
