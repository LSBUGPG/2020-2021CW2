using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialSwap : MonoBehaviour
{

    public Color normal;
    public Color highlight;
    public MeshRenderer mr;

    // Start is called before the first frame update
    public void Start()
    {
        mr = GetComponent<MeshRenderer>();
        mr.material.color = normal;
    }

    public void ColourChange()
    {
        mr.material.color = highlight;
    }
}
