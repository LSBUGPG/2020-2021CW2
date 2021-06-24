using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
	public float totalTime = 60f;
	public Text timeText;
	private bool TO;

	// Use this for initialization
	void Start()
	{
		TO = true;
		timeText.text = totalTime.ToString();
	}

	// Update is called once per frame
	void Update()
	{
		totalTime -= Time.deltaTime;
		timeText.text = Mathf.Round(totalTime).ToString();
		if (totalTime <= 0f && TO)
        {
			TimeOut();
        }
	}

	public void TimeOut()
    {
		TO = false;
		//you can put any ìthing that you want here, this function will be called when there is no time left;
    }
}
