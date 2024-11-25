using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{

    public AudioClip destructionSound; // Arrastra aquí el clip de sonido desde el Inspector
    public GameObject soundPrefab; // Alternativa: Prefab con un AudioSource para el sonido

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            // Reproduce el sonido desde un prefab
            if (soundPrefab != null)
            {
                Instantiate(soundPrefab, transform.position, Quaternion.identity);
            }
            else if (destructionSound != null) // Reproduce el sonido directamente
            {
                AudioSource.PlayClipAtPoint(destructionSound, transform.position);
            }

            // Destruye el obstáculo y este objeto
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
