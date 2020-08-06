using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotgunClass : weaponScript
{
    // Start is called before the first frame update
    void Start()
    {
        shotDelay = 1f;
        ammo = 6;
        fullAmmo = 6;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && ammo != 0 && canShoot)
        {
            canShoot = false;
            Quaternion bullet2 = Quaternion.Euler(transform.rotation.x, transform.rotation.y + 15, transform.rotation.z);
            Quaternion bullet3 = Quaternion.Euler(transform.rotation.x, transform.rotation.y - 15, transform.rotation.z);
            Instantiate(bullet, transform.position, bullet3);
            Instantiate(bullet, transform.position, transform.rotation);
            Instantiate(bullet, transform.position, bullet2);

            Invoke("shotCooldown", shotDelay);
        }
    }
}