using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{
  public Transform PlayerTransform;
  public float MoveSpeed;

    // Start is called before the first frame update
    void Start()
    {
      PlayerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
      transform.LookAt(PlayerTransform);

      transform.position += transform.forward*MoveSpeed*Time.deltaTime;
    }
}
