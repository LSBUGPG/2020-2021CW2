using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
  {

  public Rigidbody rb;
  public float health = 3;

    void Start()
    {
      rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision Other)
    {

      if (Other.collider.tag == ("Enemy"))
      {
        health -= 1;
      }
    }

    void Update()
    {
      if (health == 0)
      {
        Destroy(gameObject);
      }
    }
  }
