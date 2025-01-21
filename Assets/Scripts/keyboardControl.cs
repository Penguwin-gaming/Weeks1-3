using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboardControl : MonoBehaviour
{

    public float speed = 5;
    public float rotationSpeed = 50;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //one way to do keyboard movement
        //Vector2 pos = transform.position;

        //pos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        //pos.y += Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;

        //transform.position = pos;

        //another way to do it
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxisRaw("Vertical") * speed * Time.deltaTime, 0);
        //rotation
        transform.Rotate(0, 0, Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime * -1);
    }
}
