using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaToFlama : MonoBehaviour
{
    [SerializeField] GameObject proyectil;
    [SerializeField] GameObject mirilla;
    [SerializeField] float frecuenciaDeDisparo = 30;
    float tiempoDeEspera;

    public void Disparar()
    {
        tiempoDeEspera -= Time.deltaTime;

        if (tiempoDeEspera <= 0)
        {
            Instantiate(proyectil, mirilla.transform.position, transform.rotation);

            tiempoDeEspera = 1 / frecuenciaDeDisparo;

        }
    }
}
