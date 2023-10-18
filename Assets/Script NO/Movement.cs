using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 2.0f;
    public float distance = 2.0f;

    private Vector3 Inicial;
    private float direction = 1.0f;

    void start()
    {
        Inicial = transform.position;
    }

    void Update()
    {
        float desplazamiento = speed * Time.deltaTime * direction;

        transform.Translate(Vector3.up * desplazamiento);

        if (Mathf.Abs(transform.position.y - Inicial.y) > distance)
        {
            direction *= -1.0f;

        }
    }
}