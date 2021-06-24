using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Rigidbody enemy;
    public GameObject spawnPoint1;
    public GameObject spawnPoint2;
    public GameObject spawnPoint3;
    public GameObject spawnPoint4;

    private int count = 0;
    private int randomValue;

    private List<GameObject> spawnPointsList = new List<GameObject>();

    private void Start()
    {
        spawnPointsList.Add(spawnPoint1);
        spawnPointsList.Add(spawnPoint2);
        spawnPointsList.Add(spawnPoint3);
        spawnPointsList.Add(spawnPoint4);
    }

    private void Update()
    {
        if (count >= 60)
        {
            randomValue = Random.Range(0, 3);
            Instantiate(enemy, spawnPointsList[randomValue].transform.position, Quaternion.identity);   
            count = 0;
            return;
        }
        count += 1;
    }
}
