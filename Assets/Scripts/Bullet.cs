using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
  private float speed = 6f;
  private void Update()
  {
    transform.position += speed * Time.deltaTime * transform.up;
  }
  private void OnBecameInvisible()
  {
    GameObject.Destroy(gameObject);
  }

}
