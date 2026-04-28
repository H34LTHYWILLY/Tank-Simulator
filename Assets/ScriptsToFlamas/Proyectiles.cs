using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectiles : MonoBehaviour
{
    
    [SerializeField] float velocidad = 15;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Vector3.right * velocidad * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this);
    }
}
