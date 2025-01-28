using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatElbow : MonoBehaviour
{

    //the amount of rotation the elbow produces when the key is held, can be adjusted
    public float elbowRot = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //checks if the player inputs an A or D button press and rotates the forearm the amount declared above
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(0, 0, -elbowRot);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(0, 0, elbowRot);
        }
    }
}
