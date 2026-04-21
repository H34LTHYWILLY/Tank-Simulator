using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankPlayer : MonoBehaviour
{
    TankMovement toFlama;
    void Start()
    {
        toFlama = GetComponent<TankMovement>();
    }
    void Update()
    {
       if (Input.GetKey(KeyCode.W))
       {
          toFlama.Avanzar(+1);
       }    

       else if (Input.GetKey(KeyCode.S))
       {
          toFlama.Avanzar(-1);
       }

       else
       {
          toFlama.Avanzar(0);
       }
    }
}
