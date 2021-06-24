using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{

    public GameObject Bullet;
    public float waitFor;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(Bullet, waitFor);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
