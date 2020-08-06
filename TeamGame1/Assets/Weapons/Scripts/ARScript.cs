using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARScript : weaponScript
{
    // Start is called before the first frame update
    public override void Start()
    {
        shotDelay = 0.1f;
        ammo = 30;
        fullAmmo = 30;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && canShoot && ammo != 0)
        {
            canShoot = false;
            Instantiate(bullet, transform.position, transform.rotation);
            Invoke("shotCooldown", shotDelay);
        }

    }
}
