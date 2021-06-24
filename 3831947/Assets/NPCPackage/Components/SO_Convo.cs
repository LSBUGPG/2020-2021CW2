using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SO_Convo : ScriptableObject 
{
    public string npcName;
    public List<string> myConversation = new List<string>();
}
