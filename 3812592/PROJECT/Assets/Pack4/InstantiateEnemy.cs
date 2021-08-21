using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateEnemy : MonoBehaviour
{
  public GameObject EnemyPrefab;
  public bool CanSpawnEnemy = true;

    void Start()
    {
      StartCoroutine("EnemySpawner");
    }

    void Update()
    {

    }

    IEnumerator EnemySpawner()
    {
      while(CanSpawnEnemy)
      {
        yield return new WaitForSeconds(3f);

        Instantiate(EnemyPrefab, new Vector3 (Random.Range(-2, 2), 10, Random.Range(-2, 2)), Quaternion.identity);

        yield return null;
      }
    }
}
