using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponInteract : MonoBehaviour
{
    // Start is called before the first frame update
    public bool pistolIsTrue = true;
    GameObject pistol;
    GameObject AR;
    
    public GameObject weaponLocation;
    int currentWeapon = 0;
    int previousWeapon = 0;
    bool firstTime = true;

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
    void changeWeapons(int number)
    {
        if (firstTime)
        {
            currentWeapon = number;

        }
        else
        {
            previousWeapon = currentWeapon;
            currentWeapon = number;
        }
    }
    public int getPreviousWeapon()
    {
        return previousWeapon;
    }
}
