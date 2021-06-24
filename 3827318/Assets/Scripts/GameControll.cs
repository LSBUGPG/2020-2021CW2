using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControll : MonoBehaviour
{

    public Text GameText;
    public Text ScoreText;
    int score = 0;
    public Color[] colors;
    public string[] names;

    public Color blue;
    public Color red;
    public Color yellow;
    public Color pink;
    public Color black;
    public Color brown;
    public Color orange;
    public Color green;
    public Color purple;

    private string colorU = "blue";
    private string colorR ="red";
    private string colorY ="yellow";
    private string colorPi = "pink";
    private string colorBl ="black";
    private string colorBr ="brown";
    private string colorO ="orange";
    private string colorG ="green";
    private string colorPu ="purple";

    private Keyboard keyboardRef;
    private Timer timerRef;
    private SpeedTest speedRef;
    private ScoreFeedback feedbackRef;

    // Start is called before the first frame update
    void Start()
    {
        colors = new Color[9];
        colors[0] = red;
        colors[1] = yellow;
        colors[2] = pink;
        colors[3] = black;
        colors[4] = brown;
        colors[5] = orange;
        colors[6] = green;
        colors[7] = purple;
        colors[8] = blue;

        names = new string[9];
        names[0] = colorU;
        names[1] = colorR;
        names[2] = colorY;
        names[3] = colorPi;
        names[4] = colorBl;
        names[5] = colorBr;
        names[6] = colorO;
        names[7] = colorG;
        names[8] = colorPu;

        CreateNew();

        keyboardRef = this.GetComponent<Keyboard>();
        timerRef = this.GetComponent<Timer>();
        feedbackRef = this.GetComponent<ScoreFeedback>();
        speedRef = this.GetComponent<SpeedTest>();
    }

   

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (keyboardRef.wordTry == GameText.text)
            {
                score++;
                ScoreText.text = ("Score: " + score);
                keyboardRef.wordTry = "";
                CreateNew();
                if( speedRef.Lap() <= 1f)
                {
                    feedbackRef.TierSelector(5);
                   speedRef.currentTime = 0;
                    timerRef.totalTime += 6f;
                }
                if (speedRef.Lap() > 1f && speedRef.Lap() <= 2f)
                {
                    feedbackRef.TierSelector(4);
                   speedRef.currentTime = 0;
                    timerRef.totalTime += 5f;
                }
                if (speedRef.Lap() > 2f && speedRef.Lap() <= 3f)
                {
                    feedbackRef.TierSelector(3);
                   speedRef.currentTime = 0;
                    timerRef.totalTime += 4f;
                }
                if (speedRef.Lap() > 3f && speedRef.Lap() <= 6f)
                {
                    feedbackRef.TierSelector(2);
                   speedRef.currentTime = 0;
                    timerRef.totalTime += 3f;
                }
                if (speedRef.Lap() > 6f)
                {
                    feedbackRef.TierSelector(1);
                   speedRef.currentTime = 0;
                    timerRef.totalTime += 3f;
                }
                
            }
            else
            {
                feedbackRef.TierSelector(0);

            }
        }


    }

    public void CreateNew()
    {
        GameText.text = names[2];
        GameText.color = colors[0];
        GameText.text = names[Random.Range(0, 8)];
        GameText.color = colors[Random.Range(0, 8)]; 

    }
}
