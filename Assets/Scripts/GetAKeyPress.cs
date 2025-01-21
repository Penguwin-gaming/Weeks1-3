using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAKeyPress : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get keys other than wasd, up down left right, mouse clicks
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space!");
        }
    }
}
