using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoulderNutCracker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //code from week 1 readings that allows a object to point to where the mouse is, this works for the stiff, unjointed arm
        //of a nutcracker. the other child objects will follow the rotation of the shoulder
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouse.z = 0;
        Vector2 direction = mouse - transform.position;
        transform.up = direction;
    }
}
