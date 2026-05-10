using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Proyectiles : MonoBehaviour
{
    [SerializeField] int daño = 1;
    [SerializeField] float velocidad = 15;
    void Start()
    {

    }

    void Update()
    {
        transform.position += Vector3.right * velocidad * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        IVida objetoConVida = collision.gameObject.GetComponent<IVida>();
        if (objetoConVida != null)
        {
            objetoConVida.QuitarVida(daño);
        }

        Destroy(gameObject);
    }
}
