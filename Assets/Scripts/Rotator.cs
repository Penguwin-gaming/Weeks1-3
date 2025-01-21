using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rotates the sprite
        transform.Rotate(0, 0, speed * Time.deltaTime);

        //returns the position to zero, mouse function is incorrect as it sets based on world 0, space function is better since it is based on local 0
        if(Input.GetMouseButtonDown(1))
        {
            transform.position = Vector3.zero;
            transform.eulerAngles = Vector3.zero;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.localPosition = Vector3.zero;
            transform.localEulerAngles = Vector3.zero;
        }
    }
}
