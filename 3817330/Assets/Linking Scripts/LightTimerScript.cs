using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightTimerScript : MonoBehaviour
{
    public Light Torch;
    Image timeBar;
    public static bool depleteTimer = false;

    // Start is called before the first frame update
    void Start()
    {
        timeBar = GetComponent<Image>();
    }

    // Update is called once per frame
    public void Update()
    {
        if (ToggleTorch.on == true)
        {
            depleteTimer = true;
        }
        else
        {
            depleteTimer = false;
        }
    }
}
