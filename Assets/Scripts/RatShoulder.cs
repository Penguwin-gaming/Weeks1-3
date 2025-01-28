using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatShoulder : MonoBehaviour
{

    //the amount of rotation the shoulder produces when the key is held, can be adjusted
    public float shoulderRot = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //checks if the player inputs an A or D button press and rotates the arm the amount declared above
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, -shoulderRot);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, shoulderRot);
        }
    }
}
