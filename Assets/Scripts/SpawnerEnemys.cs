using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemys : MonoBehaviour
{
    public GameObject[] enemylist;
    void Start()
    {
        float deltetaim = Random.Range(3f, 7f);
        InvokeRepeating("Lemon",1,deltetaim);
    }

    void Lemon()
    {
        float x = Random.Range(transform.position.x - 20f, transform.position.x + 20f);
        float y = Random.Range(transform.position.y - 20f, transform.position.y + 20f);
        float z = transform.position.z;
        Vector3 startposit = new Vector3(x, y, z);
        int enemyindex = Random.Range(0,enemylist.Length);
        Instantiate(enemylist[enemyindex], startposit, transform.rotation);
    }
}
