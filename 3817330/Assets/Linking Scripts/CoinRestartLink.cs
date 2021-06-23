using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRestartLink : MonoBehaviour
{
    public GameObject winScreen;

    // Start is called before the first frame update
    void Start()
    {
        winScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (CollectScore.collected == true)
        {
            winScreen.SetActive(true);
        }
    }
}
