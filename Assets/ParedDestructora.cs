using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedDestructora : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);

    }


    void Start()
    {
        
    }

    void Update()
    {
        
    }
}