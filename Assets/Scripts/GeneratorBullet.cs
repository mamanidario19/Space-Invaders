using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorBullet : MonoBehaviour
{

  [SerializeField] private GameObject prefab;

  //  Funcion generador de prefabs.
  public void Spawn()
  {
    GameObject newObj = GameObject.Instantiate(prefab);
    newObj.transform.position = transform.position;
    newObj.transform.up = transform.up;
  }
}
