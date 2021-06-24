using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{
    public Animator objectToControl;
   
    public void DoIt()
    {
        objectToControl.SetTrigger("Activate");
    }
}
