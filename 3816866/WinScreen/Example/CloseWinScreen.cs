using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseWinScreen : MonoBehaviour
{
    public GameObject win;
    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
           win.SetActive (false);
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
