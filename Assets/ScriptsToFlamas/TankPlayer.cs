using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankPlayer : MonoBehaviour
{
    TankMovement myTankMovement;

    ArmasTankeToFlamas myReference;

    public int Vida
    {
        private set { }
        get
        {
            return 0;
        }
    }

    void Start()
    {
        myTankMovement = GetComponent<TankMovement>();
        Vida = 0;
        Debug.Log(Vida);

        myReference = GetComponent<ArmasTankeToFlamas>();
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


       if (Input.GetKey(KeyCode.Space))
       {
            myReference.Disparar();
       }



    }
}
