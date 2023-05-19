using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
  //  Clase de proyectil enemigo.
  private float speed = 7f;
  //  Movimiento continuo del Obj.
  private int direction = -1;

  private void Update()
  {
    transform.position += speed * direction * Time.deltaTime * transform.up;
  }
  //  Destruccion del Obj.
  private void OnBecameInvisible()
  {
    GameObject.Destroy(gameObject);
  }

}
