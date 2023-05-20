using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  // Script que recibe los Inputs y aplica el respectivo movimiento.
  public float speedForce = 4f;
  public float limitLeft = -2.5f;
  public float limitRight = 2.5f;

  public PlayerInputs inputs;

  void Update()
  {
    PlayerMov();
  }
  void PlayerMov()
  {
    if (inputs.movLeft && transform.position.x > limitLeft)
    {
      transform.Translate(Vector3.left * speedForce * Time.deltaTime);
    }
    if (inputs.movRight && transform.position.x < limitRight)
    {
      transform.Translate(Vector3.right * speedForce * Time.deltaTime);
    }
  }
}
