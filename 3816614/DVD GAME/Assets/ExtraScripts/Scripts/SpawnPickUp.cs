using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPickUp : MonoBehaviour
{
    public GameObject spawnOne, spawnTwo, pickUp;
    private float counter;
    private Vector2 pos;


    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        if (counter >= 3f)
        {
            pos = new Vector2(Random.Range(spawnOne.transform.position.x, spawnTwo.transform.position.x), Random.Range(4f, -2f));
            Instantiate(pickUp, pos, Quaternion.identity);
            counter = 0f;
        }
    }
}
