using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountUp : MonoBehaviour
{
    public float duration = 3f;
    public int score;
    Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText= GetComponent<Text>();
    }

    [ContextMenu("Play")]
    public void Play()
    {
        if (Application.isPlaying)
        {
            StartCoroutine(Animate(score));
        }

        else
        {
            Debug.Log("You Need o be Running");
        }
     }

    IEnumerator Animate(int target)
    {
        float t = 0;
        while (t < 1f)
        {
            scoreText.text = (target - (target / Mathf.Pow(target, t))).ToString("N0");
            t += Time.deltaTime / duration;
            yield return null;
        }
        scoreText.text = target.ToString("N0");
    }
}
