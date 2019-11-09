using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletController : MonoBehaviour
{

    private Transform bullet;
    public float speed;

    // Use this for initialization
    void Start()
    {
        bullet = GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        bullet.position += Vector3.up * -speed;

        if (bullet.position.y <= -10)
            Destroy(bullet.gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "player")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            gameover.isPlayerDead = true;
        }
        else if (other.tag == "chair")
        {
            GameObject playerBase = other.gameObject;
            chairhealth baseHealth = playerBase.GetComponent<chairhealth>();
            baseHealth.health -= 1;
            Destroy(gameObject);
        }
    }
}