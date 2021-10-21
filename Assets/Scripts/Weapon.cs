using UnityEngine;

public class Weapon : MonoBehaviour
{
  public static float damage = 30f;
  public float range = 100f;
  public float fireRate = 15;
  public float impactForce = 300000f;

  public Camera fpsCam;
  /*public ParticleSystem muzzleFlash;
  public GameObject impactEffect;*/

  private float nextTimeToFire = 0;

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKey(KeyCode.Mouse0) && Time.time >= nextTimeToFire)
    {
      nextTimeToFire = Time.time + 1f / fireRate;
      shoot();
    }

  }

  void shoot()
  {
    /*muzzleFlash.Play();*/

    RaycastHit hit;
    if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
    {
      Debug.Log(hit.transform.name);

      Target target = hit.transform.GetComponent<Target>();
      if (target != null)
      {
        target.TakeDamage(damage);
      }

      if (hit.rigidbody != null)
      {

        hit.rigidbody.AddForce(-hit.normal * impactForce);
      }

      /*GameObject impactGO = Instantiate(impactEffect, -hit.point, Quaternion.LookRotation(hit.normal));
      Destroy(impactGO, 2f);*/


    }
  }




}
