using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_SO_Convo : MonoBehaviour
{

    public Dialog_Manager dialogManager;
    public SO_Convo nyConvo;


    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            dialogManager.Start_Dialog(nyConvo);
        }
    }

    
}
