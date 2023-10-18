using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.right.normalized * speed * Time.deltaTime);
    }
}
