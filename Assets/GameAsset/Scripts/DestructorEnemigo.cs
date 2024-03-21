using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructorEnemigo : MonoBehaviour
{
    public String etiqueta;
    // Start is called before the first frame update
   public void OnCollisionEnter(Collision c){
    if (c.gameObject.CompareTag(etiqueta)){
        Destroy(c.gameObject);
    }
   }
}
