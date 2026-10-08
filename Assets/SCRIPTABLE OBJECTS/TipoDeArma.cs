using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Create Tipo de Arma")]
public class TipoDeArma : ScriptableObject 
{
    public GameObject arma;
    public GameObject balas;
    public float frecuenciaDeDisparo;
}
