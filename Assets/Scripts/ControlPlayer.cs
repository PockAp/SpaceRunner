using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    public float speed = 10f;
    public float maxspeed = 25f;
    public float normalspeed = 10f;
    public float maxrotationspeed = 100f;
    public float normalrotationspeed = 75f;
    public float rotationspeed = 75f;
    private float horizontal;
    private float vertical;
    [SerializeField] private GameManager gamemanager;
    void Start()
    {
        gamemanager.UpdateUIRings();
        gamemanager.UpdateUILives();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.Rotate(Vector3.up * rotationspeed * horizontal * Time.deltaTime);
        transform.Rotate(Vector3.left * rotationspeed * vertical * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = maxspeed;
            rotationspeed = maxrotationspeed;
        }
        else
        {
            speed = normalspeed;
            rotationspeed = normalrotationspeed;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ring"))
        {
            gamemanager.rings--;
            gamemanager.PlayRingCollect();
            Destroy(other.gameObject);
            gamemanager.UpdateUIRings();
        }

        if (other.gameObject.CompareTag("HealTag"))
        {
            gamemanager.lives++;
            gamemanager.HealPlay();
            gamemanager.UpdateUILives();
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy") || collision.collider.CompareTag("RobotEnemy"))
        {
            Debug.Log("meteorit");
            gamemanager.lives--;
            gamemanager.UpdateUILives();
        }
    }
}