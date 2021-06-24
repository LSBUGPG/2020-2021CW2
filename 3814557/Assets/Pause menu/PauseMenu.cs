using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public GameObject panelToDisable;
    CanvasGroup canvasGroup;

    public float fadeSpeed;
    float alpha = 0f;

    public string menuSceneName;

    enum FadeState
    {
        fin,
        fout
    }

    FadeState fs = FadeState.fout;

    bool fading = false;

    // Start is called before the first frame update
    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && !fading)
        {
            if(fs == FadeState.fin)
            {
                fs = FadeState.fout;
                Time.timeScale = 1;
                fading = true;
            }
            else if(fs == FadeState.fout)
            {
                fs = FadeState.fin;
                Time.timeScale = 0;
                fading = true;
            }
        }

        if(fading)
        {
            if(fs == FadeState.fin)
            {
                alpha += Time.unscaledDeltaTime * fadeSpeed;
                panelToDisable.SetActive(true);

                if(alpha >= 1)
                {
                    alpha = 1;
                    fading = false;
                }
            }
            else if(fs == FadeState.fout)
            {
                alpha -= Time.unscaledDeltaTime * fadeSpeed;

                if(alpha <= 0)
                {
                    alpha = 0;
                    fading = false;

                    panelToDisable.SetActive(false);
                }
            }

            canvasGroup.alpha = alpha;
        }
    }

    public void Continue()
    {
        fs = FadeState.fout;
        Time.timeScale = 1;
        fading = true;
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(menuSceneName);
    }
}
