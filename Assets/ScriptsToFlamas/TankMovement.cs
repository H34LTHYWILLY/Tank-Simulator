using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public float velocidadDeRotacion = 2f;

    public float velocidadDeMovimiento = 4f;

    float velocidad = 0;

    float rotacion = 0;
    void Start()
    {
        
    }
    void Update()
    {
        transform.position += transform.right * velocidad * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z + rotacion * Time.deltaTime);
    }
    public virtual void Avanzar(float ws)
    {
        velocidad = ws * velocidadDeMovimiento;
    }
    public virtual void Rotar(float ad)
    {
       rotacion = ad * velocidadDeRotacion;
    }
}
