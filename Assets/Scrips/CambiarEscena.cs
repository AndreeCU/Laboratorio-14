using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    public bool pasarNivel;
    public int indiceNivel;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CargarEscena(indiceNivel); 
        }
        if (pasarNivel)
        {
            CargarEscena(indiceNivel); 
        }
    }

    public void CargarEscena(int indice) 
    {
        SceneManager.LoadScene(indice);
    }
}