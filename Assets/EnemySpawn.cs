using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform max;
    public Transform min;
    public int speed = 5;
   
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        int num = Random.Range(0, 12);

    }
    void Start()
    {
        
    }
    
    void Update()
    {
    
    }
}
