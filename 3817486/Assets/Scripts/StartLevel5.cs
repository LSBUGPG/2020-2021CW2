using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartLevel5 : MonoBehaviour
{
    private bool playerpressedbutton;

    private void Update()
    {
        if (playerpressedbutton == true)
        {
            StartCoroutine("LoadScene5");
        }
    }


    private void OnMouseDown()
    {
        playerpressedbutton = true;
    }

    IEnumerator LoadScene5()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(4);
    }
}
