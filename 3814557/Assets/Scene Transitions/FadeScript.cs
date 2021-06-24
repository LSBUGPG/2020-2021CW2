using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeScript : MonoBehaviour
{
    public float fadeTime;
    CanvasGroup cg;

    enum FadeState
    {
        fadeIn,
        idle,
        fadeOut
    }

    FadeState fadeState;
    string sceneToLoad;

    float fadeSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        cg = GetComponent<CanvasGroup>();

        fadeState = FadeState.fadeIn;

        fadeSpeed = 1 / fadeTime;
    }

    // Update is called once per frame
    void Update()
    {

        float alpha = cg.alpha;
        
        switch(fadeState)
        {
            case (FadeState.fadeIn):
                alpha -= fadeSpeed * Time.deltaTime;

                if(alpha <= 0) fadeState = FadeState.idle;
                break;

            case (FadeState.idle):
                alpha = 0;
                break;

            case (FadeState.fadeOut):
                alpha += fadeSpeed * Time.deltaTime;
                if(alpha >= 1) 
                {
                    if(sceneToLoad == "FadeScript.FadeToQuit")
                    {
                        Application.Quit();
                    }
                    SceneManager.LoadScene(sceneToLoad);
                }
                break;
        }

        alpha = Mathf.Clamp(alpha, 0, 1);

        cg.alpha = alpha;

    }

    public void FadeToScene(string scene)
    {
        fadeState = FadeState.fadeOut;
        sceneToLoad = scene;
    }
}
