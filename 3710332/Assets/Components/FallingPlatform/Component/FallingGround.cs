using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingGround : MonoBehaviour
{
    
    
        public Transform fallingGroundDestination;
        public float speed = 1.0f;
        private Rigidbody rb;

        // Use this for initialization
        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {


        }


        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                rb.isKinematic = false;
            }

            if (other.CompareTag("Respawn"))
            {
                Destroy(gameObject);
            }
        }
    
}
