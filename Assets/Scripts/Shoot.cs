using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
  public PlayerInputs inputs;
  public GeneratorBullet generator;

  private float cooldown = 0.20f;
  private float nextShoot;

  void Update()
  {
    if (inputs.shootBullet && Time.time >= nextShoot)
    {
      SpawnShoot();
      nextShoot = Time.time + cooldown;
    }
  }
  void SpawnShoot()
  {

    generator.Spawn();

  }

}
