using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponInteract : MonoBehaviour
{
    // Start is called before the first frame update
    public bool pistolIsTrue = true;
    public GameObject pistol;
    public GameObject weaponLocation;
    // Update is called once per frame
    void Start()
    {
        if (pistolIsTrue)
        {
            pistol.SetActive(true);

        }
    }
    void Update()
    {
        
    }
}
