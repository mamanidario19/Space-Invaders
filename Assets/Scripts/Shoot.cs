using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
  public GameObject bullet;
  public PlayerInputs inputs;
  void Update()
  {
    if (inputs.shootBullet)
    {
      GameObject newBullet = GameObject.Instantiate(bullet);
      newBullet.transform.position = transform.position;
    }
  }
}
