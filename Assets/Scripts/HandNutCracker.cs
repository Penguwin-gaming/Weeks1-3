using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandNutCracker : MonoBehaviour
{
    //the amount of rotation the hand produces when the key is held, can be adjusted
    public float rotSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //checks if the player inputs a left or right mouse click and rotates the sword the amount declared above
        if(Input.GetMouseButton(0))
        {
            transform.Rotate(0, 0, -rotSpeed);
        } else if (Input.GetMouseButton(1))
        {
            transform.Rotate(0, 0, rotSpeed);
        }
    }
}
