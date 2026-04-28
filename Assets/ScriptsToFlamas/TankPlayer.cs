using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankPlayer : MonoBehaviour
{
    TankMovement myTankMovement;
    void Start()
    {
        myTankMovement = GetComponent<TankMovement>();
    }
    void Update()
    {
       if (Input.GetKey(KeyCode.W))
       {
          myTankMovement.Avanzar(+1);
       }    
       else if (Input.GetKey(KeyCode.S))
       {
          myTankMovement.Avanzar(-1);
       }
       else
       {
          myTankMovement.Avanzar(0);
       }

       if (Input.GetKey(KeyCode.D))
       {
            myTankMovement.Rotar(+1);
       } 
       else if (Input.GetKey(KeyCode.A))
       {
            myTankMovement.Rotar(-1);
       } 
       else
       {
            myTankMovement.Rotar(0);
       }




    }
}
