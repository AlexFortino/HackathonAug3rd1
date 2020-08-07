﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponInteract : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject pistolp;
    public GameObject AR;
    
  
    public int currentWeapon = 3;
    public int previousWeapon = 0;
    bool firstTime = true;

    // Update is called once per frame
   
    void Update()
    {
       
     
     
    }
        
    public void changeWeapons(int number)
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
        if (currentWeapon == 0)
        {
            pistolp.SetActive(true);

        }
        else if (currentWeapon == 1)
        {
            AR.SetActive(true);
        }
    }
    public int getPreviousWeapon()
    {
        return previousWeapon;
    }
}
