using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    public bool isDead = false;
    // Start is called before the first frame update
    void Start()
    {
        takeDamage(10);
        Debug.Log(health);
    }
    public void takeDamage(int Damage)
    {
        health = health - Damage;
    }
    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            isDead = true;
        }
    }
}
