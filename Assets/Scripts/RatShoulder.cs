using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatShoulder : MonoBehaviour
{
    //the animation curve that the shoulder will use
    public AnimationCurve curve;

    [Range(0, 1)]
    public float s;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //checks if the player inputs an A or D button press and rotates the arm based on the curve values
        //the if statements check to make sure the arms don't over rotate if the keys keep being held
        if (Input.GetKey(KeyCode.A) && s >= 0)
            {
                s -= Time.deltaTime;
                transform.Rotate(0, 0, -curve.Evaluate(s));
            }
           
        if (Input.GetKey(KeyCode.D) && s <= 1)
            {
                s += Time.deltaTime;
                transform.Rotate(0, 0, curve.Evaluate(s));
            } 
    }
}
