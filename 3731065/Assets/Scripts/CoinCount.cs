using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCount : MonoBehaviour
{
  public int points = 0;

  private void OnGUI()
  {
		GUI.Label(new Rect(20, 20, 100, 20), "Coins: " + points);
  }
}
