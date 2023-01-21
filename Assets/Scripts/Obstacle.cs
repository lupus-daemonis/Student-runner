using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
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
        GameObject obstacle = gameObject; 
        if (obstacle.tag == "Nerd")
        {
            startSpeed = -3f;
        }

    }

    void Update()
    {
        GameObject boostspeed = GameObject.Find("ObstacleSpawner");
        ObstacleSpawner obstacleSpawner = boostspeed.GetComponent<ObstacleSpawner>();
        boost = obstacleSpawner.boost;
        currentSpeed = startSpeed - boost;
        myRB.velocity = new Vector2(currentSpeed, 0);    
    }
}
