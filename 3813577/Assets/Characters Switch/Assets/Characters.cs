using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characters : MonoBehaviour
{
    public GameObject FirstPlayer;
    public GameObject SecondPlayer;
    public GameObject FirstCamera;
    public GameObject SecondCamera;
    public bool first;
    public bool second;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F))
		{
            SwitchPlayers();
		}
    }
    public void SwitchPlayers()
	{
        if(first == true)
		{
            SecondPlayer.GetComponent<PlayerMove>().enabled = true;
            SecondCamera.SetActive(true);
            SecondPlayer.GetComponent<Characters>().enabled = true;
            FirstCamera.SetActive(false);
            FirstPlayer.GetComponent<PlayerMove>().enabled = false;
            FirstPlayer.GetComponent<Characters>().enabled = false;
        }
        if(second == true)
		{
            FirstCamera.SetActive(true);
            FirstPlayer.GetComponent<PlayerMove>().enabled = true;
            FirstPlayer.GetComponent<Characters>().enabled = true;
            SecondPlayer.GetComponent<PlayerMove>().enabled = false;
            SecondCamera.SetActive(false);
            SecondPlayer.GetComponent<Characters>().enabled = false;
        }
    }
}
