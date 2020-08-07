using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class weaponScript : MonoBehaviour
{
    public GameObject bullet;
    public int damage = 10;
    public float bSpeed = 20f;
    public float shotDelay = 3f;
    public float reloadTime = 2f;
    public int shotCount = 1;
    public float accuracy = 1f;
    protected bool canShoot = true;
    public int ammo = 10;
    public int fullAmmo = 10;
    private bool fullReload;


    public virtual void Start()
    {
       
    }
    void Update()
    {
        
    }
    public virtual void reload()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ammo = fullAmmo;
        }
    }
    public void shotCooldown()
    {
        canShoot = true;

    }
}
