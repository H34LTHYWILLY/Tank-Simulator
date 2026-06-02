using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmasTankeToFlamas : MonoBehaviour
{

    public List<ArmaToFlama> alotFlamingWeapons = new List<ArmaToFlama>();
    public void Disparar()
    {
        for (int numeroArma = 0; numeroArma <= alotFlamingWeapons.Count; numeroArma++ )
        {
            alotFlamingWeapons[numeroArma].Disparar();
        }
    }

}
