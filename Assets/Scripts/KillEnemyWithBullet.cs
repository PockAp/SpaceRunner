using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemyWithBullet : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("RobotEnemy"))
        {
            Destroy(collision.gameObject);
        }
    }
}
