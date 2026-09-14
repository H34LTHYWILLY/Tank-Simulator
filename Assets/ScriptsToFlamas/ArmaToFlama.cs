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

        DisparadorDeArmas componente = collision.gameObject.GetComponent<DisparadorDeArmas>();
        // Comprobar si ese tanque puede recoger el arma.
        GameObject slotDeArma = componente.ConseguirSlotDeArmaVacio();
        if (slotDeArma == null)
            return;

        AcoplarASlotDeArma(slotDeArma, componente);
    }

    // Se llama cuando colisionamos con un arma que este en el suelo.
    public void AcoplarASlotDeArma(GameObject slotDeArma, DisparadorDeArmas componente)
    {
        // Pegar el arma al tanque.
        GameObject arma = gameObject;
        arma.transform.SetParent(slotDeArma.transform);

        arma.transform.position = slotDeArma.transform.position;
        arma.transform.rotation = slotDeArma.transform.rotation;

        // Conectar el arma a los sistemas de disparo.
        componente.alotFlamingWeapons.Add(this);

        // Incrementar la vida de nuestro tanque.
        // Y activar las colisiones del arma y su vida.
    }

    // Funcion de collision. => Quitar vida del arma y del tanque.

    // Destruir el arma.
}