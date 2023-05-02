using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputs : MonoBehaviour
{
  public bool movLeft, movRight;
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

}
