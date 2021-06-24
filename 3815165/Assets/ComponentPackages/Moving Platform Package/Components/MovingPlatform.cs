using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{

    public GameObject platformPanel;

    enum EleStates{goUP, goDown, PauseState};
    EleStates states;


    public Transform top;
    public Transform bottom;

    public float smooth;
    
    Vector3 newPos;

    bool hasRider;


    // Start is called before the first frame update
    void Start()
    {
        platformPanel.SetActive(false);
        states = EleStates.PauseState;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.T) && hasRider)
        {
            states = EleStates.goUP;
        }

        if (Input.GetKeyDown(KeyCode.Y) && hasRider)
        {
            states = EleStates.goDown;
        }

        FMS();
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "Player")
        {
            platformPanel.SetActive(true);
            coll.transform.parent = gameObject.transform;
            hasRider = true;
        }
    }

    void OntriggerExit(Collider coll)
    {
        if (coll.tag == "Player")
        {
            platformPanel.SetActive(false);
            coll.transform.parent = null;
            hasRider = false;
        }
    }

    void FMS()
    {
        if (states == EleStates.goDown)
        {
            newPos = bottom.position;
            transform.position = Vector3.Lerp(transform.position, newPos, smooth * Time.deltaTime);
        }

        if (states == EleStates.goUP)
        {
            newPos = top.position;
            transform.position = Vector3.Lerp(transform.position, newPos, smooth * Time.deltaTime);
        }

        if (states == EleStates.PauseState)
        {

        }
       
    }


}
