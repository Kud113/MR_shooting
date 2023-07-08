using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public GameObject bulletPrefab;
    public float shotSpeed = 1500;
    private float shotInterval;
    public GameObject muzzleFlashPrefab;

    void Update()
    {
        if (Trigger.trigger == true)
        {

            shotInterval += 1;

            if (shotInterval % 50 == 0)
            {

                GameObject bullet = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.Euler(transform.parent.eulerAngles.x, transform.parent.eulerAngles.y, 0));
                Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
                bulletRb.AddForce(transform.forward * shotSpeed);

                GameObject muzzleFlash = Instantiate(muzzleFlashPrefab, transform.position, transform.rotation);
                Destroy(muzzleFlash, 0.2f);

                Sounds sePlay = GameObject.Find("SePlayer").GetComponent<Sounds>();
                sePlay.Play("SE0");

                Destroy(bullet, 3.0f);
            }

        }

    }
}
