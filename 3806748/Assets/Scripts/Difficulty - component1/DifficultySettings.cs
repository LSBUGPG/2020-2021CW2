using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultySettings : MonoBehaviour
{
    public Spawner SpawnerObj;
    public GameObject EnableWhenSet;

    public Vector2 ButtonOffset = new Vector3(5, 4);
    public float[] DifficultyTimeScale = new float[3] { 0.5f, 1, 1.5f }; //Reversed
    public string[] DifficultyTexts = new string[3] { "Easy", "Medium", "Hard" };
    public Button ButtonTemplate;

    private Transform BTN_SpawnParent;
    private void Start()
    {
        BTN_SpawnParent = transform;

        for (int i = 0; i < DifficultyTimeScale.Length; i++)
        {
            Button Temp_NewButton = Instantiate(ButtonTemplate, BTN_SpawnParent);
            RectTransform RT_NewButton = Temp_NewButton.GetComponent<RectTransform>();
            RT_NewButton.position = ButtonOffset + new Vector2(0, RT_NewButton.sizeDelta.y * i);

            float TempTimeScale = DifficultyTimeScale[i];
            Temp_NewButton.onClick.AddListener(delegate { SetDifficulty(TempTimeScale); });

            Temp_NewButton.transform.GetChild(0).GetComponent<Text>().text = DifficultyTexts[i];
        }
    }

    public void SetDifficulty(float Difficulty)
    {
        SpawnerObj.DifficultyScaler = Difficulty;
        EnableWhenSet.SetActive(true);
        gameObject.SetActive(false);
    }
}
