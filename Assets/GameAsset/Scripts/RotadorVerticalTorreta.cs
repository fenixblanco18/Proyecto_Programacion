using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotadorVerticalTorreta : MonoBehaviour
{
    public float v;
    public float velocidadGiroVertical;
    
   
    // Update is called once per frame
    void Update()
    {
         v = Input.GetAxis("Vertical");
        transform.Rotate(0,0,v*Time.deltaTime*velocidadGiroVertical);
    }
}
    
    
       