using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trickshot : MonoBehaviour
{
    [Range(0, 1)]
    public float t;
    [Range(0, 1)]
    public float r;

    public AnimationCurve curve;
    public AnimationCurve spin;
    public float timer = 0;
    public float speed = 5;
    public bool willJump = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyUp(KeyCode.Space))
        {
            willJump = true;
        }

        if(willJump == true)
        {
            timer += Time.deltaTime;
        }

        if (timer > 3)
        {
            t += Time.deltaTime;
        }

        if (t > 1)
        {
            t = 0;
            timer = 0;
            willJump = false;
        }

        Vector2 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        pos.y = curve.Evaluate(t) * 2;

        Vector2 squareInScreenSpace = Camera.main.WorldToScreenPoint(pos);

        if (squareInScreenSpace.x < 0)
        {
            Vector3 fixedPos = new Vector3(0, 0, 0);
            pos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;
            speed = speed * -1;
        }

        if (squareInScreenSpace.x > Screen.width)
        {
            Vector3 fixedPos = new Vector3(Screen.width, 0, 0);
            pos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;
            speed = speed * -1;
        }

        transform.position = pos;
    }
}
