using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaSlip : MonoBehaviour
{
    public float startSpeed = -1.85f;
    public float currentSpeed;
    public float boost;
    public float flyForce = 0f;
    private Rigidbody2D myRB;
    private GameObject Player;
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.tag == "Player")
        {
            Player = obj.gameObject;
            Physics2D.IgnoreCollision(Player.GetComponent<Collider2D>(), GetComponent<Collider2D>(), true);
            startSpeed = -10f;
            flyForce = 10f;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Collector")
        {
            if (Player != null)
            {
                Physics2D.IgnoreCollision(Player.GetComponent<Collider2D>(), GetComponent<Collider2D>(), false);
            }
            startSpeed = -1.85f;
            flyForce = 0f;
        }
    }

    void Update()
    {
        GameObject boostspeed = GameObject.Find("ObstacleSpawner");
        ObstacleSpawner obstacleSpawner = boostspeed.GetComponent<ObstacleSpawner>();
        boost = obstacleSpawner.boost;
        currentSpeed = startSpeed - boost;
        myRB.velocity = new Vector2(currentSpeed, flyForce);
    }
}
