using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
  //  Script disparador de prefabs.
  public PlayerInputs inputs;
  public GeneratorBullet generator;

  private float cooldown = 0.20f;
  private float nextShoot;

  //  Condicion en la cual si se presiona el boton y el cooldown/delay es menos al establecido, dispara.
  void Update()
  {
    if (inputs.shootBullet && Time.time >= nextShoot)
    {
      SpawnShoot();
      nextShoot = Time.time + cooldown;
    }
  }
  //  Genera un disparo, llamando a la funcion Spawn del script GeneratorBullet
  void SpawnShoot()
  {

    generator.Spawn();

  }

}
