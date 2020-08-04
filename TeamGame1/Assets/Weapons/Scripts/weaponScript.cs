using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponScript : MonoBehaviour
{
    public GameObject bullet;
    public float damage = 10f;
    public float bSpeed = 10f;
    public float shotDelay = 10f;
    public float reloadTime = 2f;
    public int shotCount = 1;
    public float accuracy = 1f;
    private bool canShoot = true;
    private bool fullReload = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && canShoot)
        {
            canShoot = false;
            Instantiate(bullet, this.transform.position, this.transform.rotation);
        }
        if(Input.GetButton("Fire1") && canShoot)
        {
            canShoot = false;
            Instantiate(bullet, this.transform.position, this.transform.rotation);
        }
        canShoot = true;
    }
    void fire()
    {

    }
}
