using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparadorDeArmas : MonoBehaviour
{
    public GameObject contenedorDeSlotsDeArmas;

    [Space]

    private List<ArmaToFlama> alotFlamingWeapons = new List<ArmaToFlama>();
    private Dictionary<GameObject, ArmaToFlama> slotsAArmas
        = new Dictionary<GameObject, ArmaToFlama>();


    public void Disparar()
    {
        for (int numeroArma = 0; numeroArma < alotFlamingWeapons.Count; numeroArma++ )
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
            if (slot.transform.childCount > 0)
            {
                Transform armaHija = slot.transform.GetChild(0);
                slotsAArmas.Add(slot.gameObject, armaHija.GetComponent<ArmaToFlama>());
                alotFlamingWeapons.Add(armaHija.GetComponent<ArmaToFlama>());
            } 
            else
            {
                slotsAArmas.Add(slot.gameObject, null);
            }
        }
    }


    /*
    public void metodo()
    {
        // Array (tamaño exacto)
        // [0] - [1] - [2] - [3] - [4]
        int[] misNumeros = new int[] { 0, 1, 2, 5, 2, 4, 5 };
        misNumeros[3] = 5;


        TankLife tankA = new TankLife();
        TankLife tankB = new TankLife();
        TankLife tankC = new TankLife();
        TankLife tankD = new TankLife();

        // List (tamaño variable)
        // [0] - [1] - [2] - [3] - [4] - [+]
        List<TankLife> listaDeTanks = new List<TankLife>();
        listaDeInt.Add(tankA);  // [A]
        listaDeInt.Add(tankB);  // [A] - [B]
        listaDeInt.Add(tankD);  // [A] - [B] - [D]
        listaDeInt.Add(tankA);  // [A] - [B] - [D] - [A]

        foreach (TankLife tankLife in listaDeTanks)
        {

        }

        // HashSet (tamaño variable, elementos únicos)
        // [0] - [1] - [2] - [3] - [4] - [+]
        HashSet<TankLife> hashSetDeTanks = new HashSet<TankLife>();
        hashSetDeTanks.Add(tankA);  // [A]
        hashSetDeTanks.Add(tankB);  // [A] - [B]
        hashSetDeTanks.Add(tankD);  // [A] - [B] - [D]
        hashSetDeTanks.Add(tankA);  // [A] - [B] - [D]
        hashSetDeTanks.Add(tankC);  // [A] - [B] - [D]

        hashSetDeTanks[1];

        // A => tankA
        // B => tankB
        // C => tankC
        // D => tankD

        foreach (TankLife tankLife in hashSetDeTanks)
        {

        }

        // Dictionary (tamaño variable, elementos únicos, key => value)
        Dictionary<int, ArmaToFlama> dictionaryDeTanks = new();
        GameObject slot0 = new GameObject();
        GameObject slot1 = new GameObject();
        GameObject slot2 = new GameObject();
        GameObject slot3 = new GameObject();
        GameObject slot4 = new GameObject();
        GameObject slot5 = new GameObject();

        ArmaToFlama armaA = new ArmaToFlama();
        ArmaToFlama armaB = new ArmaToFlama();
        ArmaToFlama armaC = new ArmaToFlama();
        ArmaToFlama armaD = new ArmaToFlama();

        dictionaryDeTanks.Add(slot0, null);
        dictionaryDeTanks.Add(slot1, null);
        dictionaryDeTanks.Add(slot2, armaA);
        // dictionaryDeTanks.Add(slot3, null);
        dictionaryDeTanks.Add(slot4, null);
        dictionaryDeTanks.Add(slot5, null);

        // slot0 => null
        // slot1 => null
        // slot2 => null
        // slot3 => null
        // slot4 => null
        // slot5 => null

        dictionaryDeTanks[slot3] = armaB;
        dictionaryDeTanks[null] = armaB;
        armaB == dictionaryDeTanks[slot0];

        dictionaryDeTanks[0]; // null
        dictionaryDeTanks[1]; // armaB
        dictionaryDeTanks[2]; // null
        dictionaryDeTanks[3]; // armaB
    } */
}
