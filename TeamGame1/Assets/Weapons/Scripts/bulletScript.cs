using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    bool runOnce = true;
    public float speed = 20f;
    public bool isPlayer = false;
    public GameObject AR;
    public GameObject pistol;
    public GameObject shotgun;
    public GameObject spawner;
    // Start is called before the first frame update
    void Start()
    {
        spawner = GameObject.FindGameObjectWithTag("Spawner");
        Destroy(gameObject, 2);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
            //&& AR.active == true
        {
            //other.gameObject.GetComponent<enemyHealth>().takeDamage(AR.GetComponent<ARScript>().damage);
          
            
                spawner.GetComponent<Wave>().killEnemy(1);
                runOnce = false;
            
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        //if (other.gameObject.CompareTag("Enemy") && pistol.active == true)
        //{
        //    other.gameObject.GetComponent<enemyHealth>().takeDamage(pistol.GetComponent<pistolClass>().damage);
        //    Destroy(other.gameObject);
        //}
        //if (other.gameObject.CompareTag("Enemy") && shotgun.active == true)
        //{
        //    other.gameObject.GetComponent<enemyHealth>().takeDamage(shotgun.GetComponent<shotgunClass>().damage);
        //    Destroy(other.gameObject);
        //}
    }
}
