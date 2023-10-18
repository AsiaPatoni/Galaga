using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject objectToSpawn;
    public int speed = 5;
    int t = 0;

    public Transform Fire;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(objectToSpawn,Fire.position,Quaternion.Euler(0,5,0)); ;
        }
    }
}

