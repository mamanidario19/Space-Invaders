using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneController : MonoBehaviour
{
  public int SceneIndex;
  public void ChangeScene(int index)
  {
    SceneManager.LoadScene(index);
  }
}
