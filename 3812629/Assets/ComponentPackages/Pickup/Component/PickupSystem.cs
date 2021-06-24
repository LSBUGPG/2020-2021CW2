using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PickupSystem : MonoBehaviour
{
    public GameObject pickupCountText;
    public static int pickupCount;
    
    void Update()
    {
        pickupCountText.GetComponent<TextMeshProUGUI>().text = "SCORE: " + pickupCount;
    }
}
