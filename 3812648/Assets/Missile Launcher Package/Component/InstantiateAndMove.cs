using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateAndMove : MonoBehaviour
{

    public Rigidbody projectile;

    bool codeWorks = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (codeWorks == true)
            StartCoroutine(your_timer());
    }

    IEnumerator your_timer()
    {
        codeWorks = false;
        Debug.Log("Your enter Coroutine at" + Time.time);
        yield return new WaitForSeconds(2.0f);
        codeWorks = true;

        if (codeWorks == true)
        {
            Rigidbody clone;
            clone = Instantiate(projectile, transform.position, transform.rotation);

            clone.velocity = transform.TransformDirection(Vector3.forward * 10);
        }
    }
}
