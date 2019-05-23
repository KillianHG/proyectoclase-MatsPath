using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuentaLiftable : MonoBehaviour
{
    private int numero = 0;
    public Liftable[] cajas = new Liftable[9];

    public bool hecho;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (numero == 4)
        {
            hecho = true;
        }
        else
        {
            hecho = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Liftable"))
        {
            print("EMTRO");
            numero++;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag.Equals("Liftable"))
        {
            print("SALGO");
            numero--;
        }
    }
}