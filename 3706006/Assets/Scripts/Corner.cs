using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corner : MonoBehaviour
{
    int id = 0;
    bool calledGame;

    ShapeTrace game;

    public GameObject twin;
    public string shapeName;


    // Start is called before the first frame update
    void Start()
    {
        game = GameObject.Find(shapeName).GetComponent<ShapeTrace>();
        calledGame = false;
        if (twin != null)
        {
            twin.SetActive(false);
        }
    }

    void TurnOnTwin()
    {
        twin.SetActive(true);
    }

    public void SetID(int value)
    {
        id = value;
    }

    public int GetID()
    {
        return id;
    }

    public void DisableCorner()
    {
        print("Itta me, Corner!");
        calledGame = true;
        if (twin != null)
        {
            Invoke("TurnOnTwin", 1f);
        }
    }

    public void EnableCorner()
    {
        calledGame = false;
    }

    private void OnMouseOver()
    {
        if (calledGame == false)
        {
            game.OverCorner(this.gameObject);
        }
    }
}
