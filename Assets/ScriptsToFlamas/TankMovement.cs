using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{

    float velocidad = 0;
    void Start()
    {
        
    }
    void Update()
    {
        transform.position += transform.right * velocidad * Time.deltaTime;
    }
    public virtual void Avanzar(float w)
    {
        velocidad = w;
    }
    public virtual void Rotar(float asd)
    {
        transform.rotation = Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z + asd);
    }
}
