using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootEnemy : MonoBehaviour
{
  public GameObject enemy;
  public GameObject bulletEnemy;
  public GameObject bulletClone;

  private GameObject Aliens;

  // Update is called once per frame
  void Update()
  {
    float random = Random.Range(0f, 600f);
    Debug.Log(random);
    if (random < 0.25f)
    {
      bulletClone = Instantiate(bulletEnemy, new Vector3(enemy.transform.position.x, enemy.transform.position.y - 0.2f, 0), enemy.transform.rotation) as GameObject;
    }
  }
}
