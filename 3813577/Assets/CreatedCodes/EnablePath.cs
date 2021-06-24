using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnablePath : MonoBehaviour
{
    public GameObject path;

	private void OnTriggerEnter(Collider other)
	{
		path.SetActive(true);
	}
	private void OnTriggerExit(Collider other)
	{
		path.SetActive(false);
	}
}
