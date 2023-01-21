using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Health.health < 3)
            {
                Health.health += 1;
                gameObject.SetActive(false);
            }
        }
    }
}
