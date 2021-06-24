using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HPSystem : MonoBehaviour
{

    public GameObject HPText;
    public static int HPValue = 5;
    
    void Update()
    {
        HPText.GetComponent<TextMeshProUGUI>().text = "HP: " + HPValue;
    }
}
