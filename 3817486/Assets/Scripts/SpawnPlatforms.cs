using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatforms : MonoBehaviour
{
    public GameObject platforms;
    public GameObject coins;
    public GameObject particles;
    public GameObject turrets;

    private void Start()
    {
        platforms.gameObject.SetActive(false);
        coins.gameObject.SetActive(false);
        particles.gameObject.SetActive(false);
        turrets.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider Collision)
    {
        Debug.Log("hit");
            platforms.gameObject.SetActive(true);
            coins.gameObject.SetActive(true);
            particles.gameObject.SetActive(true);
        turrets.gameObject.SetActive(true);
    }
}
