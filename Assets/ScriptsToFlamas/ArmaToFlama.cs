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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Comprobar si estamos colisionando con un tanque.
        if (collision.gameObject.GetComponent<TankLife>() == null)
            return;

        // Comprobar si ese tanque puede recoger el arma.

        // AcoplarATanque.
    }

    // Se llama cuando colisionamos con un arma que este en el suelo.
    public void AcoplarATanque(GameObject tanque)
    {
        GameObject arma = gameObject;
        arma.transform.SetParent(tanque.transform);



        // Pegar el arma al tanque.
        // Conectar el arma a los sistemas de disparo.
        // Incrementar la vida de nuestro tanque.
        // Y activar las colisiones del arma y su vida.
    }

    // Funcion de collision. => Quitar vida del arma y del tanque.

    // Destruir el arma.
}
