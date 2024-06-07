using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 8f;  
    public float movableRange = 5.5f;
    public float power = 1000f;
    public GameObject bulletPrefab;
    public Transform spawnPoint;
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        
        transform.Translate(h * speed * Time.deltaTime, 0, 0);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -movableRange, movableRange), transform.position.y, transform.position.z);

        if (Input.GetKeyDown(KeyCode.Space))
        {
           Shoot();
        }
    }

    private void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, spawnPoint.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody2D>().AddForce(Vector3.up * power);
    }
}
