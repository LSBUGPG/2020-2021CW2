using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class DoorTrigger : MonoBehaviour
    {
    public GameObject Leftdoor;
    public GameObject Rightdoor;
    public GameObject Enemy;
    public GameObject ThePlayer;


        void OnTriggerEnter()
        {
            GetComponent<BoxCollider>().enabled = false;
        Leftdoor.SetActive(false);
        Rightdoor.SetActive(false);
        Enemy.SetActive(true);
        ThePlayer.GetComponent<Animation>().Play("movement");
        }


    }
