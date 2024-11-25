using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 5.0f; // Velocidad de movimiento del personaje

    private float xMin, xMax, yMin, yMax;

    void Start()
    {
        // Calculamos los límites de la cámara
        Camera cam = Camera.main;
        float distance = transform.position.z - cam.transform.position.z;

        // Obtenemos los límites de la pantalla en unidades de mundo
        Vector3 bottomLeft = cam.ViewportToWorldPoint(new Vector3(0, 0, distance));
        Vector3 topRight = cam.ViewportToWorldPoint(new Vector3(1, 1, distance));

        // Establecemos los límites para que el personaje no pueda salir
        xMin = bottomLeft.x;
        xMax = topRight.x;
        yMin = bottomLeft.y;
        yMax = topRight.y;
    }

    void Update()
    {
        // Capturamos el movimiento en los ejes X y Y
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float moveY = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        // Calculamos la nueva posición
        Vector3 newPosition = transform.position + new Vector3(moveX, moveY, 0);

        // Restringimos la posición dentro de los límites de la pantalla
        newPosition.x = Mathf.Clamp(newPosition.x, xMin, xMax);
        newPosition.y = Mathf.Clamp(newPosition.y, yMin, yMax);

        // Actualizamos la posición del personaje
        transform.position = newPosition;
    }
}