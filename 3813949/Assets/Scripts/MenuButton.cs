using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour
{
    public string scene;

     void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(pressbutton);
        
    }

    void pressbutton ()
    {
        SceneManager.LoadScene(scene);
    }
}
