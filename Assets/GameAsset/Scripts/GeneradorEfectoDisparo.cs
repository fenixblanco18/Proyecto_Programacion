using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class GeneradorEfectoDisparo : MonoBehaviour
{
    public GameObject prefabEfecto;

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
        //1. Crear el objeto
        GameObject go = Instantiate(
            prefabEfecto, posicion.position, posicion.rotation);
            
    }
}
