using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRot : MonoBehaviour
{
    private Vector3 rotation;
    public float rotSpeed = 17; //change the speed of rotation/ can be adjusted in the Inspector

    // Start is called before the first frame update
    void Start()
    {
        rotation = new Vector3(0, 0, rotSpeed * Time.deltaTime); 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotation);
    }
}
