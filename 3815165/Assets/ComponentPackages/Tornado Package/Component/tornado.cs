using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tornado : MonoBehaviour
{

    public Transform tornadoCenter;
    public float pullforce;
    public float refreshRate;


    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(pullObject(other, true));
        }
    }

    // Update is called once per frame
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(pullObject(other, false));
        }
    }

    IEnumerator pullObject(Collider x, bool shouldPull)
    {
        if (shouldPull)
        {
            Vector3 ForeDir = tornadoCenter.position - x.transform.position;
            x.GetComponent<Rigidbody>().AddForce(ForeDir.normalized * pullforce * Time.deltaTime);
            yield return refreshRate;
            StartCoroutine(pullObject(x, shouldPull));
        }
    }
}
