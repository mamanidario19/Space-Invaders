using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputs : MonoBehaviour
{
  public bool movLeft, movRight, shootBullet;
  public Rigidbody2D rb;

  public void ButtonPressRight()
  {
    movRight = true;
  }
  public void ButtonReleaseRight()
  {
    movRight = false;
  }
  public void ButtonPressLeft()
  {
    movLeft = true;
  }
  public void ButtonReleaseLeft()
  {
    movLeft = false;
  }
  public void ButtonShooting()
  {
    shootBullet = true;
  }
  public void ButtonReleaseShooting()
  {
    shootBullet = false;
  }
}
