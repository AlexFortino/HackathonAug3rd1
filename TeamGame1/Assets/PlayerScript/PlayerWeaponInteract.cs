using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponInteract : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject pistolp;
    GameObject AR;
    
  
    public int currentWeapon = 0;
    public int previousWeapon = 0;
    bool firstTime = true;

    // Update is called once per frame
    void Start()
    {
        int[] weaponArray = {0 , 1 };
        
        if (currentWeapon == 0)
        {
            pistolp.SetActive(true);

        }
        else if(currentWeapon == 1)
        {
            AR.SetActive(true);
        }
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
