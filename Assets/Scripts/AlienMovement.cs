using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienMovement : MonoBehaviour
{
  float timer = 0;
  float timeToMove = 0.5f;
  int numOfMovs = 0;
  float speed = 0.25f;
  int limitMov = 4;
  void Update()
  {
    //vertical movement
    if (numOfMovs == limitMov)
    {
      transform.Translate(new Vector3(0, -0.25f, 0));
      numOfMovs = -1;
      speed = -speed;
      timer = 0;
    }
    // horizontal mov
    timer += Time.deltaTime;
    if (timer > timeToMove && numOfMovs < limitMov)
    {
      transform.Translate(new Vector3(speed, 0, 0));
      timer = 0;
      numOfMovs++;
    }
  }

}