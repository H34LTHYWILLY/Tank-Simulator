using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class DisparadorDeArmas : MonoBehaviour
{
    public GameObject contenedorDeSlotsDeArmas;

    [Space]

    [HideInInspector] public List<ArmaToFlama> alotFlamingWeapons = new List<ArmaToFlama>();
    private HashSet<GameObject> slotsDeArmas = new HashSet<GameObject>();


    public void Disparar()
    {
        for (int numeroArma = 0; numeroArma < alotFlamingWeapons.Count; numeroArma++)
        {
            alotFlamingWeapons[numeroArma].Disparar();
        }
    }

    private void Start()
    {
        int numeroDeSlots = contenedorDeSlotsDeArmas.transform.childCount;
        for (int i = 0; i < numeroDeSlots; i++)
        {
            Transform slot = contenedorDeSlotsDeArmas.transform.GetChild(i);
            slotsDeArmas.Add(slot.gameObject);

            if (slot.transform.childCount > 0)
            {
                Transform armaHija = slot.transform.GetChild(0);
                alotFlamingWeapons.Add(armaHija.GetComponent<ArmaToFlama>());
            }
        }
    }

    public GameObject ConseguirSlotDeArmaVacio()
    {
        // foreach (VARIABLE in CONTENEDOR)
        foreach (GameObject slot in slotsDeArmas) // GameObject slot = slotsDeArmas[index];
        {
            if (slot.transform.childCount == 0) // Si el slot esta vacio puedo coger el arma
            {
                return slot;
            }
        }

        return null;
    }

    //public void metodo()
    //{
    //    // Array (tamaño exacto)
    //    // [0] - [1] - [2] - [3] - [4]
    //    bool[] arrayDeBools;        // Valores: 3, true, false, 5.879 (8 bytes)
    //    arrayDeBools = new bool[] { true, false, true }; // Referencias: GameObject (flechita)

    //    // [false] - [true] - [false]
    //    arrayDeBools[0] = true;
    //    arrayDeBools[1] = false;
    //    arrayDeBools[2] = true;

    //    while (true)
    //    {
    //        Debug.Log("Es true.");
    //        break;
    //    }

    //    Debug.Log("La posición 0 es " + arrayDeBools[0]);
    //    Debug.Log("La posición 1 es " + arrayDeBools[1]);
    //    Debug.Log("La posición 2 es " + arrayDeBools[2]);

    //    for (int i = 0; i < arrayDeBools.Length; i++) // Out of index exception
    //    {
    //        bool valor = arrayDeBools[i];
    //        Debug.Log("La posición" + i + " es " + valor);
    //    }


    //    //for (int i = 0; i < arrayDeBools.Length; i++)
    //    //{
    //    //    bool valor = arrayDeBools[i];
    //    //    Debug.Log(valor);
    //    //}
    //    foreach (bool valor in arrayDeBools)
    //    {
    //        Debug.Log(valor);
    //    }













    ////    int[] misNumeros = new int[] { 0, 1, 2, 5, 2, 4, 5 };
    ////    misNumeros[3] = 5;


    ////    TankLife tankA = new TankLife();
    ////    TankLife tankB = new TankLife();
    ////    TankLife tankC = new TankLife();
    ////    TankLife tankD = new TankLife();

    ////     List (tamaño variable)
    ////     [0] - [1] - [2] - [3] - [4] - [+]
    ////    List<TankLife> listaDeTanks = new List<TankLife>();
    ////    listaDeInt.Add(tankA);  // [A]
    ////    listaDeInt.Add(tankB);  // [A] - [B]
    ////    listaDeInt.Add(tankD);  // [A] - [B] - [D]
    ////    listaDeInt.Add(tankA);  // [A] - [B] - [D] - [A]

    ////    foreach (TankLife tankLife in listaDeTanks)
    ////    {

    ////    }

    ////     HashSet (tamaño variable, elementos únicos)
    ////     [0] - [1] - [2] - [3] - [4] - [+]
    ////    HashSet<TankLife> hashSetDeTanks = new HashSet<TankLife>();
    ////    hashSetDeTanks.Add(tankB);  // [B]
    ////    hashSetDeTanks.Add(tankA);  // [B] - [A]
    ////    hashSetDeTanks.Add(tankD);  // [B] - [A] - [D]
    ////    hashSetDeTanks.Add(tankA);  // [B] - [A] - [D]
    ////    hashSetDeTanks.Add(tankC);  // [B] - [A] - [D] - [C]

    //// A - A
    //// B - B
    //// C - X
    //// D - D
    //// E - X

    ////    hashSetDeTanks[0]; NO HACER NUNCA

    ////     A => tankA
    ////     B => tankB
    ////     C => tankC
    ////     D => tankD

    ////    foreach (TankLife tankLife in hashSetDeTanks)
    ////    {

    ////    }

    ////     Dictionary (tamaño variable, elementos únicos, key => value)
    ////    Dictionary<int, ArmaToFlama> dictionaryDeTanks = new();
    ////    GameObject slot0 = new GameObject();
    ////    GameObject slot1 = new GameObject();
    ////    GameObject slot2 = new GameObject();
    ////    GameObject slot3 = new GameObject();
    ////    GameObject slot4 = new GameObject();
    ////    GameObject slot5 = new GameObject();

    ////    ArmaToFlama armaA = new ArmaToFlama();
    ////    ArmaToFlama armaB = new ArmaToFlama();
    ////    ArmaToFlama armaC = new ArmaToFlama();
    ////    ArmaToFlama armaD = new ArmaToFlama();

    ////    dictionaryDeTanks.Add(slot0, null);
    ////    dictionaryDeTanks.Add(slot1, null);
    ////    dictionaryDeTanks.Add(slot2, armaA);
    ////    dictionaryDeTanks.Add(slot3, null);
    ////    dictionaryDeTanks.Add(slot4, null);
    ////    dictionaryDeTanks.Add(slot5, null);

    ////     slot0 => null
    ////     slot1 => null
    ////     slot2 => null
    ////     slot3 => null
    ////     slot4 => null
    ////     slot5 => null

    ////    dictionaryDeTanks[slot3] = armaB;
    ////    dictionaryDeTanks[null] = armaB;
    ////    armaB == dictionaryDeTanks[slot0];

    ////    dictionaryDeTanks[0]; // null
    ////    dictionaryDeTanks[1]; // armaB
    ////    dictionaryDeTanks[2]; // null
    ////    dictionaryDeTanks[3]; // armaB

    //// HashSet
    ////[A] => X
    ////[B] => X
    ////[C] => C
    ////[D] => X
    ////[E] => E
    ////[F] => X


    //// Dictionary<bool, GameObject>
    //// Dictionary<NOMBRE, VALOR que guarda el NOMBRE>
    ////[] => X
    ////[] => X
    ////[] => X
    ////[] => X
    ////[] => X
    ////[] => X

    ////dictionary.Add(false, gameObject0)
    ////dictionary.Add(true, gameObject1)

    ////[false] => gameObject0
    ////[true] => gameObject1
    

    ////dictionary[false] => gameObject0
    ////dictionary[true] => gameObject1
    //}
}