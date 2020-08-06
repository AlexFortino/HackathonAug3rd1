using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponFollow : MonoBehaviour
{   
    GameObject Enemy;
    GameObject Player;

    int currentWeapon = 1;
    int previousWeapon = 1;
  

    // Start is called before the first frame update
    void Start()
    {
        
        Player = GameObject.FindGameObjectWithTag("Player");
        currentWeapon = Player.GetComponent<PlayerWeaponInteract>().getPreviousWeapon();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
