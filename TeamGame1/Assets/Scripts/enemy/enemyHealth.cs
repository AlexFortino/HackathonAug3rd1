using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public int health = 10;
    public bool isDead = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead)
        {
            Destroy(this.gameObject);
        }
    }
    public void takeDamage(int damage)
    {
        health = health - damage;
    }
}
