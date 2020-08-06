using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotgunClass : weaponScript
{
    // Start is called before the first frame update
    public override void Start()
    {
        shotDelay = 1.5f;
        ammo = 6;
        fullAmmo = 6;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && ammo != 0)
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }
    }
}
