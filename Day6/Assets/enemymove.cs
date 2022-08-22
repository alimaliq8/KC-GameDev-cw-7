using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymove : MonoBehaviour
{
    Rigidbody RB;
    public float speed;

    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

   
    void FixedUpdate()
    {
        move();
    }

    void move()
    {
        RB.velocity = new Vector3(0, 0, speed);
    }


}
