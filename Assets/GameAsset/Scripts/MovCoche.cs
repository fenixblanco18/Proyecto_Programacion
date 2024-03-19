using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCoche : MonoBehaviour
{
    public float h;
    public float v;
    // Start is called before the first frame update
    public float velocidadRotacion;

    public float velocidadTranslacion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        transform.Rotate(0,h*Time.deltaTime*velocidadRotacion,0);
        transform.Translate(0,0,v*Time.deltaTime*velocidadTranslacion);
    }
}
