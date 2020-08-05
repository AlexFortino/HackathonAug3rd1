using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class weaponFollow : MonoBehaviour
{
    GameObject Enemy;
    GameObject Player;
    int weapon;
    // Start is called before the first frame update
    void Start()
    {
        Enemy = gameObject;
        Player = GameObject.FindGameObjectWithTag("Player");
        //weapon = Player.GetComponent<weaponsScript>();
        changeWeapon();
       
    }

    // Update is called once per frame
    void Update()
    {
        //Take same weapon as player
        
    }
    void changeWeapon()
    {

    }
}
