using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corner2 : MonoBehaviour
{
    public ShapeTrace2 game;
    public Color normal;
    public Color highlight;
    private MeshRenderer mr;

    // Start is called before the first frame update
    void Start()
    {
        game = GameObject.FindGameObjectWithTag("ShapeTrace2").GetComponent<ShapeTrace2>();
        mr = GetComponent<MeshRenderer>();
        mr.material.color = normal;
    }


    public void Highlight()
    {
        mr.material.color = highlight;
        game.AddCorner(this.gameObject);
    }
}
