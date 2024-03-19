using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayerMover : MonoBehaviour
{

    public float h;//DEFINICION
    public float v;//DWFINICION
    // Start is called before the first frame update
    public float velocidadRotacion;//COM EL OBJETO VA LENTO, ESTO LE AUMENTA LA VELOCIDAD

    public float velocidadTranslacion;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");//ANIMACION DE VALOR
        v = Input.GetAxis("Vertical");
        transform.Rotate(0,h*Time.deltaTime*velocidadRotacion,0);//PARA ROTAR UN EJE, 
        //DELTA TIME ES PARA QUE TRASCURRA UN FOTOGRAMA DETRAS DEL SIGUIENTE
        transform.Translate(0,0,v*Time.deltaTime*velocidadTranslacion);
    }
}
