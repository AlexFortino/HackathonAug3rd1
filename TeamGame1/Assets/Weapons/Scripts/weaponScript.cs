using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class weaponScript : MonoBehaviour
{
    public GameObject bullet;
    public float damage = 10f;
    public float bSpeed = 20f;
    public float shotDelay = 3f;
    public float reloadTime = 2f;
    public int shotCount = 1;
    public float accuracy = 1f;
    protected bool canShoot = true;
    private bool fullReload;


    public virtual void Start()
    {
       
    }
    void Update()
    {

    }
    public void fire()
    {
        
    }
    public void reload()
    {

    }
    public void getAmmo()
    {

    }
    public void shotCooldown()
    {
        canShoot = true;

    }
}
