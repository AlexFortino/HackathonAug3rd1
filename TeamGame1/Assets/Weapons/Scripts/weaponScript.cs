using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponScript : MonoBehaviour
{
    public GameObject bullet;
    public GameObject gun;
    public bool shoot = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void shoots()
    {
        Instantiate(bullet, this.transform.position, this.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Invoke("shoots", 1);
        }
        
    }
}
