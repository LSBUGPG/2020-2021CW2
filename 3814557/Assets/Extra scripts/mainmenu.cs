using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainmenu : MonoBehaviour
{
    public FadeScript fs;
    // Start is called before the first frame update

    public void PlayGame()
    {
        fs.FadeToScene("PlayScene");
    }

    public void CloseGame()
    {
        fs.FadeToScene("FadeScript.FadeToQuit");
    }
}
