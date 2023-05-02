using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
  public PlayerInputs inputs;
  public GeneratorBullet generator;
  void Update()
  {
    if (inputs.shootBullet)
    {
      generator.Spawn();
    }
  }
}
