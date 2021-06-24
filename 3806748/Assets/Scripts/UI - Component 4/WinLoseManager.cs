using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLoseManager : MonoBehaviour
{
    public GameObject LoseUI;
    public GameObject WinUI;
    public TextItem TimerUI;
    public TextItem ScoreUI;
    public TextItem LastScoreUI;
    public TextItem LastTimeUI;
    public TextItem GoalUI;

    public TextItem AccuracyUI;
    public TextItem MissesUI;
    public TextItem HitsUI;

    public TextItem APM_UI;

    public float StartingTime = 100;
    public float LoseTime = 0;

    private float CurrentTime;
    private float CurrentScore;
    private float ScoreChangeBy = 0;
    private float TimeChangeBy = 0;
    private bool HasWon = false;
    private bool HasLost = false;
    private float Hits = 0;
    private float Misses = 0;
    private float Shots = 0;
    private float Accuracy = 1;

    private float ObjectDecayCount = 0;
    private float ObjectDecayTimes = 0;
    private float EstimatedAPM;

    public float WinScore = 25;
    public float UIScoreMultiplier = 1;

    private float UpdateTimerCurrent;

    // Start is called before the first frame update
    void Start()
    {
        LoseUI.SetActive(false);
        CurrentTime = StartingTime;
    }

    private void Update()
    {
        if(UpdateTimerCurrent >= Time.timeScale)
        {
            UpdateTimerCurrent = 0;
            AddTime();
        }
        else
        {
            UpdateTimerCurrent += Time.deltaTime;
        }

        UpdateUI();
        DisplayGoal();
    }

    public void AddTime(float Time = -1)
    {
        CurrentTime += Time;
        TimeChangeBy = Time;

        UpdateUI(true, false, false);

        if (!HasLost && !HasWon)
        {
            CheckIfLose();
        }
    }

    public void AddScore(float NewScore, bool IsAHit = true)
    {
        Shots++;

        if (CurrentScore + NewScore > 0)
        {
            CurrentScore += NewScore;
            ScoreChangeBy = NewScore;
        }
        else
        {
            ScoreChangeBy = -CurrentScore;
            CurrentScore = 0;
        }

        if (IsAHit)
        {
            Hits++;
        }
        else
        {
            Misses++;
        }

        Accuracy = Hits / Shots;

        UpdateUI(false, true, true);

        if (!HasLost && !HasWon)
        {
            CheckIfWin();
        }
    }

    public void AddObjectDecayTime(float Time)
    {
        ObjectDecayCount++;
        ObjectDecayTimes += Time;
        EstimatedAPM = 60 / (ObjectDecayTimes / ObjectDecayCount);
        UpdateUI(false, false, false, true);
    }

    private void UpdateUI(bool UpdateTimer = true, bool UpdateScore = true, bool UpdateAccuracy = true, bool UpdateAPM = true)
    {
        if (UpdateTimer)
        {
            TimerUI.UpdateUI(TimerUI.StartingText + ((int) CurrentTime).ToString() + TimerUI.EndText);

            string StartingText = "";
            if (TimeChangeBy > 0) { StartingText = "+"; }
            LastTimeUI.UpdateUI(StartingText + ((int) TimeChangeBy).ToString() + LastTimeUI.EndText, true);
        }

        if (UpdateScore)
        {
            ScoreUI.UpdateUI(ScoreUI.StartingText + ((int) (CurrentScore * UIScoreMultiplier)).ToString() + ScoreUI.EndText);

            string StartingText = "";
            if(ScoreChangeBy > 0) { StartingText = "+"; }
            LastScoreUI.UpdateUI(StartingText + ((int) (ScoreChangeBy * UIScoreMultiplier)).ToString() + LastScoreUI.EndText, true);
        }

        if (UpdateAccuracy)
        {
            MissesUI.UpdateUI(MissesUI.StartingText + Misses.ToString() + MissesUI.EndText);
            HitsUI.UpdateUI(HitsUI.StartingText + Hits.ToString() + HitsUI.EndText);
            AccuracyUI.UpdateUI(AccuracyUI.StartingText + (Accuracy * 100).ToString("F2") + AccuracyUI.EndText, true, true, Accuracy);
        }

        if (UpdateAPM)
        {
            APM_UI.UpdateUI(APM_UI.StartingText + EstimatedAPM.ToString("F0") + APM_UI.EndText);
        }
    }

    private void CheckIfLose()
    {
        if(CurrentTime <= LoseTime)
        {
            LoseState();
        }
    }

    private void CheckIfWin()
    {
        if (CurrentScore * UIScoreMultiplier >= WinScore)
        {
            WinState();
        }
    }

    private void LoseState()
    {
        HasLost = true;
        TimerUI.ChangeUIState();
        LoseUI.SetActive(true);
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        Time.timeScale = 0f;
    } 

    private void WinState()
    {
        HasWon = true;
        ScoreUI.ChangeUIState();
        WinUI.SetActive(true);
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        Time.timeScale = 0;
    }

    private void DisplayGoal()
    {
        GoalUI.UpdateUI(GoalUI.StartingText + WinScore.ToString() + GoalUI.EndText);
    }
}
