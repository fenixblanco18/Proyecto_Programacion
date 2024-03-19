using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlainMove : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    public float h;//DEFINICION
    public float v;//DEFINICION
    public float angularSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0,speed*Time.deltaTime);
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        transform.Rotate(
        v*Time.deltaTime*angularSpeed,
        h*Time.deltaTime*angularSpeed,
        0);

        transform.Translate(
        0,
        0,
        speed*Time.deltaTime);
        
    }
}
