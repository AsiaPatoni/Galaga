using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    public int speed = 5;

    void Start()
    {
        
    }

    void Update()
    {
       

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up.normalized * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down.normalized * speed * Time.deltaTime);
        }
    }
}
