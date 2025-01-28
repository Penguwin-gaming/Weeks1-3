using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatHand : MonoBehaviour
{

    //the animation curve that the hand will use
    public AnimationCurve curve;

    [Range(0, 1)]
    public float h;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //checks if the player inputs an Q or E button press and rotates the sword based on the curve values
        //the if statements check to make sure the sword doesn't over rotate if the keys keep being held and hurt the rat
        if (Input.GetKey(KeyCode.E) && h >= 0)
        {
            h -= Time.deltaTime;
            transform.Rotate(0, 0, -curve.Evaluate(h));
        }

        if (Input.GetKey(KeyCode.Q) && h <= 1)
        {
            h += Time.deltaTime;
            transform.Rotate(0, 0, curve.Evaluate(h));
        }
    }
}
