using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class RatElbow : MonoBehaviour
{

    //the animation curve that the elbow will use
    public AnimationCurve curve;

    [Range(0, 1)]
    public float e;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //checks if the player inputs an W or S button press and rotates the forearm based on the curve values
        //the if statements check to make sure the forearm doesn't over rotate if the keys keep being held
        if (Input.GetKey(KeyCode.S) && e >= 0)
        {
            e -= Time.deltaTime;
            transform.Rotate(0, 0, -curve.Evaluate(e));
        }

        if (Input.GetKey(KeyCode.W) && e <= 1)
        {
            e += Time.deltaTime;
            transform.Rotate(0, 0, curve.Evaluate(e));
        }
    }
}
