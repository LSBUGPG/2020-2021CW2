using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemovePlatforms : MonoBehaviour
{
    public GameObject platforms;
    public GameObject coins;
    public GameObject particles;
    public GameObject turrets;

    private void Start()
    {
        platforms.gameObject.SetActive(true);
        coins.gameObject.SetActive(true);
        particles.gameObject.SetActive(true);
        turrets.gameObject.SetActive(true);
    }

    void OnTriggerEnter(Collider Collision)
    {

        Debug.Log("hitremove");
        
            platforms.gameObject.SetActive(false);
            coins.gameObject.SetActive(false);
            particles.gameObject.SetActive(false);
            turrets.gameObject.SetActive(false);
        
    }
}
