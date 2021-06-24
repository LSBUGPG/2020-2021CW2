using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restartlevel : MonoBehaviour
{

	private void OnTriggerEnter(Collider other)
	{
		Application.LoadLevel(Application.loadedLevel);
	}
}
