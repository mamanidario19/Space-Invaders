using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
  //  Clase de proyectil.
  private float speed = 7f;
  //  Movimiento continuo del Obj.

  private void Update()
  {
    transform.position += speed * Time.deltaTime * transform.up;
  }
  //  Destruccion del Obj.
  private void OnBecameInvisible()
  {
    GameObject.Destroy(gameObject);
  }

}
