using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public static int health;
    public GameObject Pizza1, Pizza2, Pizza3;
    void Start()
    {
        Pizza1.SetActive(true);
        Pizza2.SetActive(true);
        Pizza3.SetActive(true);
        health = 3;   
    }

    void Update()
    {
        switch (health)
        {
            case 3:
                Pizza1.SetActive(true);
                Pizza2.SetActive(true);
                Pizza3.SetActive(true);
                break;

            case 2:
                Pizza1.SetActive(true);
                Pizza2.SetActive(true);
                Pizza3.SetActive(false);
                break;

            case 1:

                Pizza1.SetActive(true);
                Pizza2.SetActive(false);
                Pizza3.SetActive(false);
                break;
            case 0:

                Pizza1.SetActive(false);
                Pizza2.SetActive(false);
                Pizza3.SetActive(false);
                break;

        }   
    }
}
