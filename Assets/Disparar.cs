using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public GameObject BalaInicio;
    public GameObject BalaPrefab;
    public float BalaSpeed;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject Bala = Instantiate(BalaPrefab, BalaInicio.transform.transform.position, BalaInicio.transform.rotation) as GameObject; 

            Rigidbody rb = Bala.GetComponent<Rigidbody>();

            rb.AddForce(transform.forward * BalaSpeed);

        }
    }
}
