using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;

public class RobotEnemyMove : MonoBehaviour
{
    private float speedenemy;
    void Start()
    {
        speedenemy = Random.Range(10f, 25f);
    }



    void Update()
    {
        transform.Translate(Vector3.forward * speedenemy * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("DestroyWall"))
        {
            Debug.Log("—“≈Õ¿");
            Destroy(gameObject);
        }
    }
}
