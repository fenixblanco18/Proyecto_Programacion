using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Disparador : MonoBehaviour
{
    public GameObject prefabProyectil;

    public float fuerza;
    public Transform posicion;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")){
            Disparar();
    }
    }
    void Disparar(){
        print("Disparando...");
    }
}
