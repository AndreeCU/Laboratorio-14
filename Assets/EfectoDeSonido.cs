using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectoDeSonido : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            // Reproduce el sonido
            if (audioSource != null)
            {
                audioSource.Play();
            }
         // Destruye el enemigo
        }
    }
}
