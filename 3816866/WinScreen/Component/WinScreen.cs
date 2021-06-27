using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScreen : MonoBehaviour
{
    public AudioSource music;
   

    // Start is called before the first frame update
    private void OnEnable()
    {
        music.Play();
    }

    private void OnDisable()
    {
        music.Stop();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
