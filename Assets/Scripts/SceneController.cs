using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneController : MonoBehaviour
{
  // Script encargado del movimiento entre escenas.
  public int SceneIndex;
  public void ChangeScene(int index)
  {
    SceneManager.LoadScene(index);
  }
}
