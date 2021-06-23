using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CornerZones : MonoBehaviour
{
    public GameObject cam;
    //public GameObject[] corners;

    private Vector2 camDefaultPos;
    private float fodDefault = 60f;
    private float fodZoom = 30f;
    private float fodCurrent;
    // Start is called before the first frame update
    void Start()
    {
        camDefaultPos = cam.transform.position;
        fodCurrent = cam.GetComponent<Camera>().fieldOfView;
    }

    // Update is called once per frame
    void Update()
    {
        //INSETAD OF EFFECTING THE FOD ZOOM IN USING THE Z AXIS OF THE TRANSFORM COMPONENT
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CornerZone"))
        {
            Time.timeScale = 0.5f;
            cam.transform.position = transform.position;
            if (fodCurrent > fodZoom)
            {
                fodCurrent--;
            }
        }
        //if (other.CompareTag("Corner"))
        //{
        //    particleEffect.transform.position = transform.position;
        //    particleEffect.SetActive(true);
        //    StartCoroutine(TurnOffParticles());
        //}
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("CornerZone"))
        {
            Time.timeScale = 1f;
            cam.transform.position = camDefaultPos;
            if (fodCurrent < fodDefault)
            {
                fodCurrent++;
            }
        }
    }
    IEnumerator TurnOffParticles()
    {
        yield return new WaitForSeconds(2f);
        //particleEffect.SetActive(false);
    }
}
