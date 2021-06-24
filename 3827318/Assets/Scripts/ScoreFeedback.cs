using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreFeedback : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Text Feedbackbox;
    public Color Tier0;
    public string Message0;
    public Color Tier1;
    public string Message1;
    public Color Tier2;
    public string Message2;
    public Color Tier3;
    public string Message3;
    public Color Tier4;
    public string Message4;
    public Color Tier5;
    public string Message5;

    float t = 1.4f;

    // Update is called once per frame
    void Update()
    { 
    }

    public void TierSelector( int n )
    {
        if (n==0)
        { Do0(); }
        if(n == 1)
        { Do1(); }
        if(n == 2)
        { Do2(); }
        if(n == 3)
        { Do3(); }
        if(n == 4)
        { Do4(); }
        if(n == 5)
        { Do5(); }

    }

    private void Do0()
    {
        Feedbackbox.text = Message0;
        Feedbackbox.color = Tier0;
    }
    private void Do1()
    {
        Feedbackbox.text = Message1;
        Feedbackbox.color = Tier1;
    }
    private void Do2()
    {
        Feedbackbox.text = Message2;
        Feedbackbox.color = Tier2;
    }
    private void Do3()
    {
        Feedbackbox.text = Message3;
        Feedbackbox.color = Tier3;
    }
    private void Do4()
    {
        Feedbackbox.text = Message4;
        Feedbackbox.color = Tier4;
    }
    private void Do5()
    {
        Feedbackbox.text = Message5;
        Feedbackbox.color = Tier5;
    }
}
