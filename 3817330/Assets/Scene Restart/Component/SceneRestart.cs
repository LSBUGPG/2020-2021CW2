using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneRestart : MonoBehaviour
{
    public GameObject restartScene;

    public void Restart()
    {
        SceneManager.LoadScene("Scene Restart");
    }
}
