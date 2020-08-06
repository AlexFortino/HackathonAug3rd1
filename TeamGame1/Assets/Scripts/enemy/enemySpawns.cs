using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawns : MonoBehaviour
{
    public GameObject EnemySpawner;
    public float spawnTime;


    private float spawnTimer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer > 1)
        {
            Instantiate(EnemySpawner, transform.position, Quaternion.identity);
            spawnTimer = 0;

        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.SetActive(false);
            Destroy(this.gameObject, 0.0f);
        }
    }

}