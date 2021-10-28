using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
  public Camera cam;

  void OnCollisionEnter(Collision collision)
  {

    Target target = collision.gameObject.transform.GetComponent<Target>();

    if (collision.gameObject.name == "First Person Player")
    {
      Debug.Log("-30");
      //   target.TakeDamage(Weapon.damage);

    }
    else if (collision.gameObject.name == "Modular military character")
    {
      target.TakeDamage(Weapon.damage);
      Debug.Log(Weapon.damage);

    }
  }
}
