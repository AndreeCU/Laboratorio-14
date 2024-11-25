using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            GameObject spawner = GameObject.FindWithTag("Spawner");
            if (spawner != null)
            {
                spawner.GetComponent<EnemySpawner>().SpawnEnemy();
            }

            Destroy(gameObject); 
            Destroy(collision.gameObject);
        }
    }

    void Update()
    {
        
    }
}
