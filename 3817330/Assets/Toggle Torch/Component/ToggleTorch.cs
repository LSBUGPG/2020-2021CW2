using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleTorch : MonoBehaviour
{
    public Light Torch;
    public  static bool on = false;

    // Start is called before the first frame update
    void Start()
    {
        on = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (on == true)
            {
                Torch.enabled = false;
                on = false;
            }
            else
            {
                Torch.enabled = true;
                on = true;
            }
        }
    }
}
