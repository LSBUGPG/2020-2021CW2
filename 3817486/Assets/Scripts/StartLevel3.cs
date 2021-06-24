using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartLevel3 : MonoBehaviour
{
    private bool playerpressedbutton;

    private void Update()
    {
        if (playerpressedbutton == true)
        {
            StartCoroutine("LoadScene3");
        }
    }


    private void OnMouseDown()
    {
        playerpressedbutton = true;
    }

    IEnumerator LoadScene3()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(2);
    }
}
