using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 1; 
    public GameObject explosionPrefab; 
    public EnemySpawner spawner;

    void Awake()
    {
        Destroy(gameObject, life); 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            AudioSource audioSource = collision.gameObject.GetComponent<AudioSource>();
            if (audioSource != null)
            {
                audioSource.Play();
            }
            Animator animator = collision.gameObject.GetComponent<Animator>();
            if (animator != null)
            {
                animator.SetTrigger("Explode");
            }

            Destroy(collision.gameObject, 1f);

            if (spawner != null)
            {
                spawner.SpawnEnemy();
            }
            else
            {
                Debug.LogWarning("Spawner no asignado a la bala.");
            }

            Destroy(gameObject);
        }
    }
}