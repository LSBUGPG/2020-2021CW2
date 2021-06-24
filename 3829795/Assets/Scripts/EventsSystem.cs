using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventsSystem : MonoBehaviour
{

    public string triggerTag;
    public UnityEvent triggerAction;

    void OnTriggerEnter (Collider collider)
    {
        if (collider.CompareTag(triggerTag))
        {
            triggerAction.Invoke();
        }
    }
}
