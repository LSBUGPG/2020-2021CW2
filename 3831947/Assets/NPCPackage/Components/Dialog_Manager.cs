using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog_Manager : MonoBehaviour
{

    public GameObject dialogPanel;
    public Text npcNameText;
    public Text dialogText;

    private List<string> conversation;
    private int convoIndex;

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    public void Start_Dialog(string _npcName, List<string> _convo)
    {
        npcNameText.text = _npcName;
        conversation = new List<string>(_convo);
        dialogPanel.SetActive(true);
        convoIndex = 0;
        ShowText();

    }

    public void Start_Dialog(SO_Convo _convo)
    {
        npcNameText.text = _convo.npcName;
        conversation = new List<string>(_convo.myConversation);
        dialogPanel.SetActive(true);
        convoIndex = 0;
        ShowText();
    }
    // Update is called once per frame
    public void StopDialog()
    {
        dialogPanel.SetActive(false);
    }

    private void ShowText()
    {
        dialogText.text = conversation[convoIndex];

    }

    public void Next()
    {
        if (convoIndex < conversation.Count - 1)
        {
            convoIndex += 1;
            ShowText();
        }
    }
}
