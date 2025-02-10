using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bullet;
    public GameObject leftpoint;
    public GameObject rightpoint;
    [SerializeField] private GameManager gamemanager;

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            DoubleShooting();
            gamemanager.ShootPlay();
            Invoke("DoubleShooting", 0.1f);
        }
    }

    void DoubleShooting()
    {
        Quaternion bulletrot = Quaternion.Euler(leftpoint.transform.rotation.eulerAngles.x, leftpoint.transform.rotation.eulerAngles.y, 0);
        Instantiate(bullet, leftpoint.transform.position, bulletrot);
        Instantiate(bullet, rightpoint.transform.position, bulletrot);
    }
}