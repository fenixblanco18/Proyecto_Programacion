using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotadorVerticalTorreta : MonoBehaviour
{
    public float v;
    public float velocidadGiroVertical;
    

    [SerializeField]

    private float anguloMinimo = 300;

    [SerializeField]
    private float anguloMaximo = 355;

    private float z; 
    
   
    // Update is called once per frame
    void Update()
    {
         v = Input.GetAxis("Vertical");
         z = transform.rotation.eulerAngles.z;
         if ((v>0 && z<=anguloMaximo) || (v<0 && z>=anguloMinimo)){
            transform.Rotate(0,0,v*Time.deltaTime*velocidadGiroVertical);
        }
    }
}
    
    
       