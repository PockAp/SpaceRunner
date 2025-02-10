using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    private float speed = 50f;

    
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
