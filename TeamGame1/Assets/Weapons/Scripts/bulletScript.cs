using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    public float speed = 20f;
    public bool isPlayer = false;
    public GameObject AR;
    public GameObject pistol;
    public GameObject shotgun;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy") && AR.activeSelf == true)
        {
            other.gameObject.GetComponent<enemyHealth>().takeDamage(AR.GetComponent<ARScript>().damage);
        }
        if (other.gameObject.CompareTag("Enemy") && pistol.activeSelf == true)
        {
            other.gameObject.GetComponent<enemyHealth>().takeDamage(pistol.GetComponent<pistolClass>().damage);
        }
        if (other.gameObject.CompareTag("Enemy") && shotgun.activeSelf == true)
        {
            other.gameObject.GetComponent<enemyHealth>().takeDamage(shotgun.GetComponent<shotgunClass>().damage);
        }
    }
}
