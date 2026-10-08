using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject metralleta;
    public GameObject pistola;
    public GameObject tank;

    public float tiempoEntreSpawns = 5;
    private float tiempoDesdeElSpawn;
    // Update is called once per frame
    void Update()
    {
        if (tiempoDesdeElSpawn >= tiempoEntreSpawns)
        {
            Vector3 posicionDeCreacion = (Vector3)Random.insideUnitCircle + tank.transform.position;
            Instantiate(metralleta, posicionDeCreacion, Quaternion.identity);
            tiempoDesdeElSpawn = 0;
        }
        else
        {
            tiempoDesdeElSpawn += Time.deltaTime;
        }
        
    }
}
