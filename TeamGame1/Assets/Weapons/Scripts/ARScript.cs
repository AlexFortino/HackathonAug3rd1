using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARScript : weaponScript
{
    // Start is called before the first frame update
    void Start()
    {
        shotDelay = 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && canShoot)
        {
            canShoot = false;
            Instantiate(bullet, transform.position, transform.rotation);
            Invoke("shotCooldown", shotDelay);
        }

    }
}
