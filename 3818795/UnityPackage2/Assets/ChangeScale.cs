using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeScale : MonoBehaviour
{
    public int Score;
    public int Score2;
    public bool CanIncrease = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Score = ButtonClick.Clicks;
        Score2 = ButtonClick.Clicks2;
        if (Score2 >= 10)
        {
            CanIncrease = true;
            IncreaseSize();
        }
        
        
    }

    public void IncreaseSize()
    {
        if (CanIncrease == true)
        {
            transform.localScale += new Vector3(1, 1, 0);
            Score2 = 0;
            CanIncrease = false;

        }
        
        
    }
    
}
