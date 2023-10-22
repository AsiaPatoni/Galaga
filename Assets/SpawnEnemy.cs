using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject clone;
    public float timer = 0.5f;
    public float Speed = 5.0f;


    private void Start()
    {
        InvokeRepeating("SpawnObject", 0, timer);
    }
    private void Update()
    {
        transform.Translate(Vector3.left * Speed * Time.deltaTime);
    }
    void SpawnObject()
    {
        float randomY = Random.Range(0f, 20f);
        Vector3 spawnPosition = new Vector3(transform.position.x, randomY, transform.position.z);
        Instantiate(clone, spawnPosition, Quaternion.identity);
    }
}