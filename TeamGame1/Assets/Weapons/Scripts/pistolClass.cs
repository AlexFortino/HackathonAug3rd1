using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pistolClass : weaponScript
{
    // Start is called before the first frame update
    
    public override void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }
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
}
