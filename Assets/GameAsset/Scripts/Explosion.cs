using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject prefabExplosion;
    // Start is called before the first frame update
  public void OnCollisionEnter();
     Instantiate(prefabExplosion, transform.position, transform.rotation);
     Destroy(GameObject);
}
