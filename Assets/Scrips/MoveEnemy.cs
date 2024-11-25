using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public float speed = 5f; // Velocidad del movimiento
    private Vector2 direction = Vector2.left; // Dirección inicial (hacia la izquierda)

    void Update()
    {
        // Mover el enemigo en la dirección actual
        transform.Translate(direction * speed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Verificar si el objeto con el que colisionó tiene el tag "Pared"
        if (collision.gameObject.CompareTag("Pared"))
        {
            // Cambiar la dirección del movimiento
            direction = (direction == Vector2.left) ? Vector2.right : Vector2.left;

            // Alternativamente, podrías rotar al enemigo si lo deseas
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        }
    }
}
