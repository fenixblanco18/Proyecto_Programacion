using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructorEnemigo : MonoBehaviour
{
    public String tag;
    // Start is called before the first frame update
   public void OnCollisionEnter(Collision c){
    if (c.gameObject.CompareTag(tag)){
        Destroy(c.gameObject);
    }
   }
}
