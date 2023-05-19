using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
  public GameObject bullet; // El objeto que debe destruir al entrar en contacto

  private void OnCollisionEnter2D(Collision2D collision)
  {
    if (collision.gameObject.tag == "alien")
    {
      Destroy(collision.gameObject);
      Destroy(bullet); // Destruye el objeto actual cuando colisiona con el alien
    }
  }
}
