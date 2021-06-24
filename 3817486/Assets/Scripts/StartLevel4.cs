using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartLevel4 : MonoBehaviour
{
    private bool playerpressedbutton;

    private void Update()
    {
        if (playerpressedbutton == true)
        {
            StartCoroutine("LoadScene4");
        }
    }


    private void OnMouseDown()
    {
        playerpressedbutton = true;
    }

    IEnumerator LoadScene4()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(3);
    }
}
