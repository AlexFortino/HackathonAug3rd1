using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponFollow : MonoBehaviour
{   
    GameObject Enemy;
    GameObject Player;

    int currentWeapon = 0;
    int previousWeapon = 0;
    GameObject pistol;
    GameObject AR;


    // Start is called before the first frame update
    void Start()
    {
        List<int> weaponList = new List<int>();
        weaponList.Add(0);
        weaponList.Add(1);

      
        Player = GameObject.FindGameObjectWithTag("Player"); 
        currentWeapon = Player.GetComponent<PlayerWeaponInteract>().getPreviousWeapon(); 
       
        switch (currentWeapon)
        {
            case 0:
                pistol.SetActive(true);
                break;
            case 1:
                AR.SetActive(true);
                break;
          

        }

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    /*public void changeWeapons(int number)
    {
           currentWeapon = number;

       
    }*/

}
