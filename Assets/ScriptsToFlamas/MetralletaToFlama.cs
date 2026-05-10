using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetralletaToFlama : MonoBehaviour
{
    [SerializeField] GameObject proyectil;
    [SerializeField] GameObject mirilla;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(proyectil, mirilla.transform.position, transform.rotation);
        }
    }
}
