using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstacles;
    public List<GameObject> obstaclesToSpawn = new List<GameObject>();

    int index;
    public float boost = 0f;
    public float changeSpeed = 0.09f;

    private void Awake()
    {
        InitObstacles();
    }

    void Start()
    {
        StartCoroutine(SpawnRandomObstacle());  
    }

    void InitObstacles()
    {
        index = 0;
        for (int i = 0; i < obstacles.Length * 2; i++)
        {
            GameObject obj = Instantiate(obstacles[index], transform.position, Quaternion.identity);
            obstaclesToSpawn.Add(obj);
            obstaclesToSpawn[i].SetActive(false);
            index++;

            if(index == obstacles.Length)
            {
                index = 0;
            }
        }    
    }

    IEnumerator SpawnRandomObstacle()
    {
        yield return new WaitForSeconds(Random.Range(1.0f, 4.0f));

        int index = Random.Range(0, obstaclesToSpawn.Count);

        while (true)
        {
            if (!obstaclesToSpawn[index].activeInHierarchy)
            {
                obstaclesToSpawn[index].SetActive(true);
                obstaclesToSpawn[index].transform.position = transform.position;
                break;
            }
            else
            {
                index = Random.Range(0, obstaclesToSpawn.Count);
            }
        }

        StartCoroutine(SpawnRandomObstacle());
    }

    void Update()
    {
        boost += Time.deltaTime * changeSpeed;
    }
}
